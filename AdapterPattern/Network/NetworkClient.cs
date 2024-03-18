using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Network
{
    public class NetworkClient : INetworkClient
    {
        public void SendRequest(string iPAddress)
        {
            Console.WriteLine($"Network client request send to IP :  {iPAddress}");
        }
    }
}
