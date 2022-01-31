using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class KlientuRepositorija
    {
        private List<Klientas> klientai = new List<Klientas>();


        public KlientuRepositorija()
        {
            klientai.Add(new Klientas(1, "Kajus", "Adomenas"));
            klientai.Add(new Klientas(2, "Darius", "Sakalauskas"));
            klientai.Add(new Klientas(3, "Saulius", "Petraitis"));
            klientai.Add(new Klientas(4, "Justinas", "Vasiliauskas"));
            klientai.Add(new Klientas(5, "Erikas", "Grigas"));

        }

        public List<Klientas> GetKlientas()
        {
            return klientai;
        }
        public Klientas GetKlientas(int id)
        {
            var kazkoksKlientas = klientai.FirstOrDefault(x => x.KlientoId == id);

            return kazkoksKlientas;
        }

        public void PridetiKlienta(Klientas klientas)
        {
            klientas.KlientoId = klientai.LastOrDefault().KlientoId + 1;
            klientai.Add(klientas);
        }

        public void IstrintiKlienta(int id)
        {
            if (klientai != null)
            {
                var kazkoksKlientas = klientai.FirstOrDefault(x => x.KlientoId == id);
                klientai.Remove(kazkoksKlientas);
            }
            else
            {
                Console.WriteLine("Ataskaita Tuščia pridekite klienta");
            }
        }
    }
}
