using System;
using System.Collections.Generic;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class Produktas
    {
        public int ProduktoId { get; set; }
        public string ProduktoVardas { get; set; }
        public double ProduktoKaina { get; set; }

        public Produktas()
        {

        }
        
        public Produktas(int produktoId, string produktoVardas, double produktoKaina)
        {
            ProduktoId = produktoId;
            ProduktoVardas = produktoVardas;
            ProduktoKaina = produktoKaina;

        }

    }

}
