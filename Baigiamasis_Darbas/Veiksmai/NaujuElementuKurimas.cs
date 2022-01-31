using System;
using System.Collections.Generic;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class NaujuElementuKurimas
    {
        private KlientuRepositorija _klientuRepositorija;
        private ProduktoRepositorija _produktoRepositorija;
        private UzsakymoRepositorija _uzsakymoRepositorija;

        public NaujuElementuKurimas()
        {
            _klientuRepositorija = new KlientuRepositorija();
            _produktoRepositorija = new ProduktoRepositorija();
            _uzsakymoRepositorija = new UzsakymoRepositorija();
        }
        public Klientas NaujasKlientas()
        {
            Console.WriteLine("Iveskite Kliento Varda : ");
            string klientoVardas = Console.ReadLine();
            Console.WriteLine("Iveskite Kliento Pavarde : ");
            string klientoPavarde = Console.ReadLine();

            var klientas = new Klientas();
            klientas.KlientoVardas = klientoVardas;
            klientas.KlientoPavarde = klientoPavarde;

            return klientas;
        }
        public Produktas NaujasProduktas()
        {
            Console.WriteLine("Iveskite Produkto Pavadinima : ");
            string produktoPavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite Produkto Kaina: ");
            double produktoKaina = double.Parse(Console.ReadLine());

            var produktas = new Produktas();
            produktas.ProduktoVardas = produktoPavadinimas;
            produktas.ProduktoKaina = produktoKaina;

            return produktas;
        }

        public Uzsakymas NaujasUzsakymas()
        {
            Console.WriteLine("Iveskite Kliento ID :");
            int klientoId = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite Produkto ID:");
            int produktoId = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite kieki :");
            int kiekis = int.Parse(Console.ReadLine());

            var uzsakymas = new Uzsakymas();
            uzsakymas.KlientoId = klientoId;
            uzsakymas.ProduktoId = produktoId;
            uzsakymas.ProduktoKiekis = kiekis;

            return uzsakymas;
        }

        public int Istrinti()
        {
            Console.WriteLine("Iveskite ID, kuri norite pasalinti: ");
            int id;
            bool pasalinti = int.TryParse(Console.ReadLine(), out id);

            return id;
        }

    }
}

