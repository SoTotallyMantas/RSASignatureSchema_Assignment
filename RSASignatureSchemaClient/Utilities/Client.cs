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
    internal class Client
    {
        public string responseMessage { get; set; }
        public Client()
        {
        }
        public async Task Connection(IPEndPoint ipEndPoint, string message,BigInteger signature,BigInteger publickey,BigInteger modulus)
        {
            using Socket client = new(
            ipEndPoint.AddressFamily,
            SocketType.Stream,
                ProtocolType.Tcp);
            await client.ConnectAsync(ipEndPoint);
            while (true)
            {
                //Send Indentifier
                var buffer = Encoding.UTF8.GetBytes("Client");
                await client.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
                if (await ReceiveMessage(client) == "Success")
                {
                    // Send Message

                   await SendData(client, message, signature, publickey, modulus);
                }
                else
                {
                    MessageBox.Show("Server is not ready");
                    break;
                }
                // Receive Message
                if(CheckForExit(await ReceiveMessage(client)))
                {
                    break;
                }
                


            }

            client.Shutdown(SocketShutdown.Both);
        }
        private async Task SendData(Socket client, string message, BigInteger signature, BigInteger publickey, BigInteger modulus)
        {
            
            // Send Message

            var buffer = Encoding.UTF8.GetBytes(message);
            await client.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);

            if (await ReceiveMessage(client) != "Received")
            {
                Task.Delay(1000); 
            }
            
            // Send Signature
            buffer = signature.ToByteArray();
            await client.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);

            if (await ReceiveMessage(client) != "Received")
            {
                Task.Delay(1000);
            }
            // Send Public Key
            buffer = publickey.ToByteArray();
            await client.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);

            if (await ReceiveMessage(client) != "Received")
            {
                Task.Delay(1000);
            }
            // Send Modulus
            buffer = modulus.ToByteArray();
            await client.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
        }
        private async Task<string> ReceiveMessage(Socket client)
        {
            var response = new byte[1024];
            var responseBuffer = await client.ReceiveAsync(response);
            return Encoding.UTF8.GetString(response, 0, responseBuffer);
        }
        private bool CheckForExit(string message)
        {
            if (message == "exit")
            {
                return true;
            }
            return false;
        }
        

    }
}
