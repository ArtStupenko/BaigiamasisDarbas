using System;
using System.Collections.Generic;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class ReportUzsakymas
    {
        public int UzsakymoId { get; set; }
        public string KlientoVardas { get; set; }
        public string KlientoPavarde { get; set; }
        public int ProduktoId { get; set; }
        public string ProduktoVardas { get; set; }
        public int ProkuktoKiekis { get; set; }
        public double ProduktoKaina { get; set; }
        public double VisaSuma { get; set; }

    }
}
