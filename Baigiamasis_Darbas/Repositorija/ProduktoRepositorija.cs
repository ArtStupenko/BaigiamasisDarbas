using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class ProduktoRepositorija
    {
        private List<Produktas> produktai = new List<Produktas>();

        public ProduktoRepositorija()
        {
            produktai.Add(new Produktas(1, "Pienas", 1.99));
            produktai.Add(new Produktas(2, "Miltai", 2.99));
            produktai.Add(new Produktas(3, "Sultys", 4.99));
            produktai.Add(new Produktas(4, "Surelis", 0.99));
            produktai.Add(new Produktas(5, "Riešutai (100g)", 3.99));
        }

        public List<Produktas> GetProduktas()
        {
            return produktai;
        }

        public Produktas GetProduktas(int id)
        {
            return (produktai.FirstOrDefault(x => x.ProduktoId == id));
        }

        public void PridetiProdukta(Produktas produktas)
        {
            produktas.ProduktoId = produktai.LastOrDefault().ProduktoId + 1;
            produktai.Add(produktas);
        }

        public void IstrintiProdukta(int id)
        {
            if (produktai != null)
            {
                var kazkoksProduktas = produktai.FirstOrDefault(x => x.ProduktoId == id);
                produktai.Remove(kazkoksProduktas);
            }
            else
            {
                Console.WriteLine("Ataskaita Tuščia pridekite produktą");
            }
        }
    }
}
