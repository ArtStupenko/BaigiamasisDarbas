using System;
using System.Collections.Generic;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class Klientas
    {
        public int KlientoId { get; set; }
        public string KlientoVardas { get; set; }
        public string KlientoPavarde { get; set; }


        public Klientas()
        {

        }
        public Klientas(int klientoId, string klientoVardas, string klientoPavarde)
        {
            KlientoId = klientoId;
            KlientoVardas = klientoVardas;
            KlientoPavarde = klientoPavarde;
        }
    }
}
