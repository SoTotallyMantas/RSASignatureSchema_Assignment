using RSACertificateEndpoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSACertificateClient.Utilities
{
    internal class EndpointClient
    {
        public string responseMessage { get; set; }
        public EndpointClient()
        {
        }
        public async Task Connection(IPEndPoint ipEndPoint, Form1 form)
        {
            using Socket Endpoint = new(
            ipEndPoint.AddressFamily,
            SocketType.Stream,
                ProtocolType.Tcp);
            await Endpoint.ConnectAsync(ipEndPoint);
            while (true)
            {
                //Send Indentifier
                var buffer = Encoding.UTF8.GetBytes("Endpoint");
                await Endpoint.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
                string success = await ReceiveMessage(Endpoint);
                if (success == "Success")
                {
                    // Send Message

                   await Receivedata(Endpoint,form);
                   

                }
                else
                {
                    MessageBox.Show("Server is not ready");
                    break;
                }
                if (CheckForExit(await ReceiveMessage(Endpoint)))
                {
                    break;
                }





            }

            Endpoint.Shutdown(SocketShutdown.Both);
        }
        private async Task Receivedata(Socket Endpoint,Form1 form)
        {

           
            
            string receivedMessage = await ReceiveMessage(Endpoint);
            await SendReceived(Endpoint);
            // Receive Signature
           BigInteger signature = await ReceiveBigIntegerAsync(Endpoint);
            await SendReceived(Endpoint);
            // Receive Exponent
            BigInteger Exponent = await ReceiveBigIntegerAsync(Endpoint);
            await SendReceived(Endpoint);
            // Receive Modulus
            BigInteger Modulus = await ReceiveBigIntegerAsync(Endpoint);
            await SendReceived(Endpoint);
            form.Invoke(new Action(() =>
            {

                form.Messagerichbox1.Text = receivedMessage;
                form.Signaturetextbox1.Text = signature.ToString();
                form.Modulustextbox1.Text = Modulus.ToString();
                form.Exponenttextbox1.Text = Exponent.ToString();
            }));
          
        }

        private async Task<string> ReceiveMessage(Socket Endpoint)
        {
            byte[] buffer = new byte[1024];
            var received = await Endpoint.ReceiveAsync(buffer, SocketFlags.None);
            return Encoding.UTF8.GetString(buffer, 0, received);
        }
        private async Task<BigInteger> ReceiveBigIntegerAsync(Socket Endpoint)
        {
            byte[] buffer = new byte[1024];
            var receivedBytes = await Endpoint.ReceiveAsync(buffer, SocketFlags.None);

            byte[] validBytes = new byte[receivedBytes];
            Array.Copy(buffer, validBytes, receivedBytes);

            return new BigInteger(validBytes);
        }
        private bool CheckForExit(string message)
        {
            if (message == "exit")
            {
                return true;
            }
            return false;
        }
        private async Task SendReceived(Socket handler)
        {
            var Message = "Received";
            var echoBytes = Encoding.UTF8.GetBytes(Message);
            await handler.SendAsync(echoBytes, SocketFlags.None);
        }


    }
}
