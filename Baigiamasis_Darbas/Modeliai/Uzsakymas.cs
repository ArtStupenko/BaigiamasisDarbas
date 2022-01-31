using System;
using System.Collections.Generic;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class Uzsakymas
    {
        public int UzsakymoId { get; set; }
        public int KlientoId { get; set; }
        public int ProduktoId { get; set; }
        public int ProduktoKiekis { get; set; }


        public Uzsakymas()
        {

        }

        public Uzsakymas(int uzsakymoId, int klientoId, int produktoId, int produktoKiekis)
        {
            UzsakymoId = uzsakymoId;
            KlientoId = klientoId;
            ProduktoId = produktoId;
            ProduktoKiekis = produktoKiekis;
        }
    }
}
