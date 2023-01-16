using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Gioco_Oca_Client
{
    internal class CConessione
    {
       

public class ServerConnection
    {
        private TcpClient client;
        private NetworkStream stream;
        private string serverAddress;
        private int serverPort;

        public ServerConnection(string serverAddress, int serverPort)
        {
            this.serverAddress = serverAddress;
            this.serverPort = serverPort;
        }

        public void Connect()
        {
            client = new TcpClient(serverAddress, serverPort);
            stream = client.GetStream();
        }

        public void Disconnect()
        {
            stream.Close();
            client.Close();
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        public string ReceiveMessage()
        {
            byte[] data = new byte[256];
            int bytes = stream.Read(data, 0, data.Length);
            return Encoding.ASCII.GetString(data, 0, bytes);
        }
    }

}
}
