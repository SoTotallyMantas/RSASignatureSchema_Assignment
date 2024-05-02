using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSACertificate_Server.SocketServer
{
    internal class Serversocket
    {
        public string receivedMessage;
        public BigInteger Signature;
        public BigInteger Modulus;
        public BigInteger Exponent;
        public bool CloseServer = false;
        public List<Socket> clients = new List<Socket>();
        public List<Socket> endpoints = new List<Socket>();
        public Serversocket()
        {
           
        }

        public async Task Start(Form1 form)
        {
            
            // Create a new socket
            IPEndPoint ipEndpoint = new(IPAddress.Any, 8888);
            using Socket listener = new(ipEndpoint.AddressFamily,
                SocketType.Stream,
                ProtocolType.Tcp);
            listener.Bind(ipEndpoint);
            listener.Listen(100);
            
           
            
            while (true)
            {

                var handler = await listener.AcceptAsync();
                string Identifier = await ReceiveMessage(handler);
                if (Identifier == "Client")
                {
                    clients.Add(handler);
                }
                else if (Identifier == "Endpoint")
                {
                    endpoints.Add(handler);
                }

                // Receive Message
                if (clients.Count>=1)
                  { 
                    // Send Success Message
                  await SendSuccess(clients[0]);
                    // Receive Message
                     receivedMessage = await ReceiveMessage(clients[0]);
                    await  SendReceived(handler);
                    // Receive Signature
                    Signature =await ReceiveBigIntegerAsync(clients[0]);
                    await SendReceived(clients[0]);
                    // Receive Exponent
                    Exponent = await ReceiveBigIntegerAsync(clients[0]);
                    await SendReceived(clients[0]);
                    // Receive Modulus
                    Modulus = await ReceiveBigIntegerAsync(clients[0]);
                    form.Invoke(new Action(() =>
                    {
                        form.Messagerichbox1.Text = receivedMessage;
                        form.Signaturetextbox1.Text = Signature.ToString();
                        form.Modulustextbox1.Text = Modulus.ToString();
                        form.Exponenttextbox1.Text = Exponent.ToString();
                    }));
                    // Send Exit Message
                   await SendExit(clients[0]);
                    clients[0].Disconnect(true);
                    clients.Remove(clients[0]);
                   
                    

                }
               
               
              

            }

        }
        public async Task SendData(Socket handler ,Form1 form)
        {
                // Send Success Message
                await SendSuccess(handler);
           
                // Send Message

                var buffer = Encoding.UTF8.GetBytes(form.Messagerichbox1.Text);
                await handler.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);

                if (await ReceiveMessage(handler) != "Received")
                {
                    Task.Delay(1000);
                }

            await SendBigIntegerAsync(handler, form.Signaturetextbox1.Text); 
            await SendBigIntegerAsync(handler, form.Exponenttextbox1.Text); 
            await SendBigIntegerAsync(handler, form.Modulustextbox1.Text); 
           // Send Exit Message
            await SendExit(handler);
           
            endpoints[0].Disconnect(true);
            endpoints.Remove(endpoints[0]);

                
            
        }
        private async Task SendBigIntegerAsync(Socket handler, string text)
        {
            
            BigInteger bigInt =  BigInteger.Parse(text);
            byte[] buffer = bigInt.ToByteArray();

            await handler.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);

            if (await ReceiveMessage(handler) != "Received")
            {
                await Task.Delay(1000);
            }
        }
        private  async Task<string> ReceiveMessage(Socket handler)
        {
            byte[] buffer = new byte[1024];
            var received = await handler.ReceiveAsync(buffer,SocketFlags.None);
            return Encoding.UTF8.GetString(buffer, 0, received);
        }
        private async Task<BigInteger> ReceiveBigIntegerAsync(Socket handler)
        {
            byte[] buffer = new byte[1024];
            var receivedBytes = await handler.ReceiveAsync(buffer, SocketFlags.None);

            byte[] validBytes = new byte[receivedBytes];
            Array.Copy(buffer, validBytes, receivedBytes);

            return new BigInteger(validBytes);
        }
        private  async Task SendSuccess(Socket handler)
        {
            var Message = "Success";
            var echoBytes = Encoding.UTF8.GetBytes(Message);
            await handler.SendAsync(echoBytes, SocketFlags.None);
        }
        private async Task SendExit(Socket handler)
        {
            var Message = "exit";
            var echoBytes = Encoding.UTF8.GetBytes(Message);
            await handler.SendAsync(echoBytes, SocketFlags.None);
        }
        private async Task SendReceived(Socket handler)
        {
            var Message = "Received";
            var echoBytes = Encoding.UTF8.GetBytes(Message);
            await handler.SendAsync(echoBytes, SocketFlags.None);
        }
       

       
    }
}
