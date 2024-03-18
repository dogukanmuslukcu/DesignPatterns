using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.DataProcess
{
    public class DataProcessor : IDataProcessor
    {
        public bool DataProcess() 
        {
            Console.WriteLine("Data processed");
            return true;
        }
        public void SendRequestNetwork(string ipAddress, string apiKey) 
        {
            Console.WriteLine($"Network client request send to IP {ipAddress} ");


        }
    }
}
