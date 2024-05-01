using EncryptionAssignment.EncryptionDecryption;
using EncryptionAssignment.Util;
using RSACertificate_Server.SocketServer;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace RSACertificate_Server
{
    public partial class Form1 : Form
    {

        private bool _CheckServerStatus = false;
        Serversocket serversocket = new();
        public bool CheckServerStatus { get => CheckServerStatus; set => CheckServerStatus = value; }
        internal Serversocket Serversocket { get => serversocket; set => serversocket = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private async void StartServer_Click(object sender, EventArgs e)
        {


            if (!_CheckServerStatus)
            {
                _CheckServerStatus = true;
                serversocket.CloseServer = false;
                await serversocket.Start(this);
                MessageBox.Show("Server Started");
            }
            else
            {

                MessageBox.Show("Server Already Started");
            }

        }





        private void CheckSignature_Click(object sender, EventArgs e)
        {
            RSAEncryptionDecryption rsa = new();

            BigInteger exponent = BigInteger.Parse(Exponenttextbox.Text);
            BigInteger modulus = BigInteger.Parse(Modulustextbox.Text);
            BigInteger signature = BigInteger.Parse(Signaturetextbox.Text);

            // Verify the signature
            BigInteger signatureCheck = rsa.CheckSignatureRSA(exponent, modulus, signature);

            // Convert the message to bytes using UTF-8 encoding
            byte[] messageBytes = Encoding.UTF8.GetBytes(Messagerichbox.Text);

            // Convert the message bytes to a BigInteger
            BigInteger messageBigInt = new BigInteger(messageBytes);

            // Compare the signature check with the message BigInteger
            if (signatureCheck.Equals(messageBigInt))
            {
                MessageBox.Show("Signature is Valid");
            }
            else
            {
                MessageBox.Show("Signature is Invalid");
            }
        }

        private void NewSignature_Click(object sender, EventArgs e)
        {
            RSAEncryptionDecryption rSAEncryptionDecryption = new();
            byte[] data = rSAEncryptionDecryption.CreateSignatureRSA(Qprime.Text, Pprime.Text, Messagerichbox.Text);
            BigInteger SignatureData = new BigInteger(data);
            Signaturetextbox.Text = SignatureData.ToString();
            Exponenttextbox.Text = rSAEncryptionDecryption.Exponent.ToString();
            Modulustextbox.Text = rSAEncryptionDecryption.Modulus.ToString();

            MessageBox.Show("Signature Created");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pprime.Text = GeneratePrimeNumber.GeneratePrimeNumbers(512).ToString();
            Qprime.Text = GeneratePrimeNumber.GeneratePrimeNumbers(512).ToString();
        }

       
    }
}