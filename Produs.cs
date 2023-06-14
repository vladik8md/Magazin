using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    internal class Produs
    {
        public int CodProdus { get; set; }
        public string CategorieProdus { get; set; }
        public string DenumireProdus { get; set; }
        public double PretProdus { get; set; }

        public Produs(int codProdus, string categorieProdus, string denumireProdus, double pretProdus)
        {
            CodProdus = codProdus;
            CategorieProdus = categorieProdus;
            DenumireProdus = denumireProdus;
            PretProdus = pretProdus;
        }

        public override string ToString()
        {
            return $"{CodProdus},{CategorieProdus},{DenumireProdus},{PretProdus}";
        }
    }
}
