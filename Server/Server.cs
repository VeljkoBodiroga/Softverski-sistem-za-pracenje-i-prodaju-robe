using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        Socket osluskujuciSoket;
        
        private List<ClientHandler> handlers = new List<ClientHandler>();

        public Server()
        {
            osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Pokreni()
        {

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            osluskujuciSoket.Bind(endPoint);
            osluskujuciSoket.Listen(1000);

            Thread nit = new Thread(PrihvatiKlijenta);
            nit.IsBackground = true;
            nit.Start();



        }

        public void PrihvatiKlijenta()
        {
            try
            {
                while (true)
                {
                    Socket klijent = osluskujuciSoket.Accept();
                    ClientHandler handler = new ClientHandler(klijent, this);
                    handlers.Add(handler);
                    Thread klijentskaNit = new Thread(handler.Handle);
                    klijentskaNit.IsBackground = true;
                    klijentskaNit.Start();
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine("SE>>>" + se.Message);
            }
            catch (IOException io)
            {
                Debug.WriteLine("IO>>>" + io.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("EX>>>" + ex.Message);
            }
        }

        public void Stop()
        {
            List<ClientHandler> copy = new List<ClientHandler>(handlers);
            foreach (ClientHandler handler in copy)
            {
                handler.CloseSocket();
            }
            handlers.Clear();
            osluskujuciSoket.Close();
        }

        private object _lock = new object();
        internal void RemoveClient(ClientHandler handler)
        {
            lock (_lock)
            {
                handlers.Remove(handler);
            }
        }
    }
}
