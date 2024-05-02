using EncryptionAssignment.EncryptionDecryption;
using RSACertificateClient.Utilities;
using System.Net;
using System.Numerics;
using System.Text;

namespace RSACertificateEndpoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void ReceiveData_Click(object sender, EventArgs e)
        {
            EndpointClient endpointClient = new();
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            await endpointClient.Connection(ipendpoint, this);
        }

        private void CheckSignature_Click(object sender, EventArgs e)
        {
            RSAEncryptionDecryption rsa = new();

            BigInteger exponent = BigInteger.Parse(Exponenttextbox.Text);
            BigInteger modulus = BigInteger.Parse(Modulustextbox.Text);
            BigInteger signature = BigInteger.Parse(Signaturetextbox.Text);


            BigInteger signatureCheck = rsa.CheckSignatureRSA(exponent, modulus, signature);


            byte[] messageBytes = Encoding.UTF8.GetBytes(Messagerichbox.Text);


            BigInteger messageBigInt = new BigInteger(messageBytes);


            if (signatureCheck.Equals(messageBigInt))
            {
                MessageBox.Show("Signature is Valid");
            }
            else
            {
                MessageBox.Show("Signature is Invalid");
            }
        }
    }
}