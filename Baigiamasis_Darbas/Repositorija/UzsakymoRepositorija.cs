using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class UzsakymoRepositorija
    {

        private List<Uzsakymas> uzsakymai = new List<Uzsakymas>();

        public UzsakymoRepositorija()
        {
            uzsakymai.Add(new Uzsakymas(1, 1, 5, 15));
            uzsakymai.Add(new Uzsakymas(2, 2, 4, 50));
            uzsakymai.Add(new Uzsakymas(3, 3, 3, 30));
            uzsakymai.Add(new Uzsakymas(4, 4, 2, 5));
            uzsakymai.Add(new Uzsakymas(5, 5, 1, 1));
            uzsakymai.Add(new Uzsakymas(6, 1, 5, 8));
            uzsakymai.Add(new Uzsakymas(7, 2, 4, 9));
            uzsakymai.Add(new Uzsakymas(8, 3, 3, 10));
            uzsakymai.Add(new Uzsakymas(9, 4, 2, 7));
            uzsakymai.Add(new Uzsakymas(10, 5, 1, 6));
            uzsakymai.Add(new Uzsakymas(11, 2, 3, 3));
            uzsakymai.Add(new Uzsakymas(12, 4, 4, 2));

        }

        public List<Uzsakymas> GetUzsakymas()
        {
            return uzsakymai;
        }

        public Uzsakymas GetUzsakymas(int id)
        {
            return (uzsakymai.FirstOrDefault(x => x.UzsakymoId == id));
        }

        public void PridetiUzsakyma (Uzsakymas uzsakymas)
        {
            uzsakymas.UzsakymoId = uzsakymai.LastOrDefault().UzsakymoId + 1;
            uzsakymai.Add (uzsakymas);
        }

        public void IstrintiUzsakyma(int id)
        {
            if (uzsakymai != null)
            {
                var kazkoksUzsakymas = uzsakymai.FirstOrDefault(x => x.UzsakymoId == id);
                uzsakymai.Remove(kazkoksUzsakymas);
            }
            else
            {
                Console.WriteLine("Ataskaita Tuščia pridekite uzsakyma");
            }

        }
    }
}
