using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.DataProcess
{
    public interface IDataProcessor
    {
        bool DataProcess();
        void SendRequestNetwork(string ipAddress, string apiKey);
    }
}
