using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    internal class Client
    {
        public string CodClient { get; set; }
        public string NumeClient { get; set; }
        public string PrenumeClient { get; set; }
        public double SumaClient { get; set; }

        public Client(string codClient, string numeClient, string prenumeClient, double sumaClient)
        {
            CodClient = codClient;
            NumeClient = numeClient;
            PrenumeClient = prenumeClient;
            SumaClient = sumaClient;
        }

        public override string ToString()
        {
            return $"{CodClient},{NumeClient},{PrenumeClient},{SumaClient}";
        }
    }
}
