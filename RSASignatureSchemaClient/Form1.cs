using EncryptionAssignment.EncryptionDecryption;
using EncryptionAssignment.Util;
using System.Net;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace RSACertificateClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void SendData_Click(object sender, EventArgs e)
        {
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            RSAEncryptionDecryption rsa = new RSAEncryptionDecryption();
            byte[] Data = rsa.CreateSignatureRSA(Pprime.Text, Qprime.Text, MessageRichBox.Text);
            BigInteger signature = new BigInteger(Data);
            Utilities.Client client = new Utilities.Client();
            BigInteger publickey = rsa.Exponent;
            BigInteger modulus = rsa.Modulus;
            string message = MessageRichBox.Text;
            try
            {
                await client.Connection(ipendpoint, message, signature, publickey, modulus);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void GenerateValues_Click(object sender, EventArgs e)
        {
            Pprime.Text = GeneratePrimeNumber.GeneratePrimeNumbers(512).ToString();
            Qprime.Text = GeneratePrimeNumber.GeneratePrimeNumbers(512).ToString();
        }

    
    }
}