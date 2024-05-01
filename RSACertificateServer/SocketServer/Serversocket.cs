using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RSACertificate_Server.SocketServer
{
    internal class Serversocket
    {
        public string receivedMessage;
        public BigInteger Signature;
        public BigInteger Modulus;
        public BigInteger Exponent;
        public bool CloseServer = false;
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
            listener.Listen(10);
            var handler = await listener.AcceptAsync();
            while(!CloseServer)
            {
                // Receive Message
               
                if(await ReceiveMessage(handler) == "Client")
                {
                    // Send Success Message
                  await SendSuccess(handler);
                    // Receive Message
                     receivedMessage = await ReceiveMessage(handler);
                    await  SendReceived(handler);
                    // Receive Signature
                    Signature =await ReceiveBigIntegerAsync(handler);
                    await SendReceived(handler);
                    // Receive Exponent
                    Exponent = await ReceiveBigIntegerAsync(handler);
                    await SendReceived(handler);
                    // Receive Modulus
                    Modulus = await ReceiveBigIntegerAsync(handler);
                    form.Invoke(new Action(() =>
                    {
                        form.Messagerichbox1.Text = receivedMessage;
                        form.Signaturetextbox1.Text = Signature.ToString();
                        form.Modulustextbox1.Text = Modulus.ToString();
                        form.Exponenttextbox1.Text = Exponent.ToString();
                    }));
                    // Send Exit Message
                   await SendExit(handler);

                    break;
                }
              

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
