using AdapterPattern.DataProcess;
using AdapterPattern.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdapterPattern
{
    public class NetworkAdapter : INetworkClient
    {
        private readonly DataProcessor _dataProcessor;
        public NetworkAdapter()
        {
            _dataProcessor = new ();
        }
        public void SendRequest(string iPAddress)
        {
            //get apikey securiable methods
            var apiKey = "supersecretapikey";
            _dataProcessor.SendRequestNetwork(iPAddress,apiKey);
        }
    }
}
