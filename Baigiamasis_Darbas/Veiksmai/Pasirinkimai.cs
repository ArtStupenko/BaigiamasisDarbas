using System;
using System.Collections.Generic;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class Pasirinkimai
    {
        private KlientuRepositorija _klientuRepositorija;
        private ProduktoRepositorija _produktoRepositorija;
        private UzsakymoRepositorija _uzsakymoRepositorija;

        public Pasirinkimai()
        {
            _klientuRepositorija = new KlientuRepositorija();
            _produktoRepositorija = new ProduktoRepositorija();
            _uzsakymoRepositorija = new UzsakymoRepositorija();
        }

        public void SukurtiMenu()
        {
            Console.WriteLine("Pasirinkite ataskaitos tipa");
            Console.WriteLine("[1] - Visu Klientu Ataskaita");
            Console.WriteLine("[2] - Visu Uzsakymu Ataskaita");
            Console.WriteLine("[3] - Visu Produktu Ataskaita");
            Console.WriteLine("[4] - Prideti/Istrinti Klienta");
            Console.WriteLine("[5] - Prideti/Istrinti Produkta");
            Console.WriteLine("[6] - Prideti/Istrinti Uzsakyma");
            Console.WriteLine("[7] - Iseiti");



            int pasirinkimas;
            bool success = int.TryParse(Console.ReadLine(), out pasirinkimas);

            switch (pasirinkimas)
            {
                case 1:
                    Console.Clear();
                    Spausdinimas spausdinimas1 = new Spausdinimas();
                    spausdinimas1.KlientuSpausdinimas(_klientuRepositorija);
                    break;
                case 2:
                    Console.Clear();
                    Spausdinimas spausdinimas2 = new Spausdinimas();
                    spausdinimas2.UzsakymuSpausdinimas(_klientuRepositorija, _produktoRepositorija, _uzsakymoRepositorija);
                    break;
                case 3:
                    Console.Clear();
                    Spausdinimas spausdinimas3 = new Spausdinimas();
                    spausdinimas3.ProduktuSpausdinimas(_produktoRepositorija);
                    break;
                case 4:
                    Console.Clear();
                    KlientuMenu();
                    break;
                case 5:
                    Console.Clear();
                    ProduktuMenu();
                    break;
                case 6:
                    Console.Clear();
                    UzsakymuMenu();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Bloga Ivestis");
                    break;


            }
        }
        public void KlientuMenu()

        {
            var naujuElementuKurimas = new NaujuElementuKurimas();
            Console.WriteLine("Pasirinkite Veiksma: \n");
            Console.WriteLine("[1] - Prideti Nauja Klienta");
            Console.WriteLine("[2] - Istrinti Klienta");
            Console.WriteLine("[3] - Grizti");

            int pasirinkimas;
            bool success = int.TryParse(Console.ReadLine(), out pasirinkimas);

            switch (pasirinkimas)
            {
                case 1:
                    Console.Clear();
                    var naujasKlientas = naujuElementuKurimas.NaujasKlientas();
                    _klientuRepositorija.PridetiKlienta(naujasKlientas);
                    break;
                case 2:
                    Console.Clear();
                    var spausdinimas = new Spausdinimas();
                    spausdinimas.KlientuSpausdinimas(_klientuRepositorija);
                    var istrinti = new NaujuElementuKurimas();
                    _klientuRepositorija.IstrintiKlienta(istrinti.Istrinti());
                    break;

                default:
                    break;


            }
        }
        public void ProduktuMenu()

        {
            var naujuElementuKurimas = new NaujuElementuKurimas();
            Console.WriteLine("Pasirinkite Veiksma: \n");
            Console.WriteLine("[1] - Prideti Nauja Produkta");
            Console.WriteLine("[2] - Istrinti Produkta");
            Console.WriteLine("[3] - Grizti");

            int pasirinkimas;
            bool success = int.TryParse(Console.ReadLine(), out pasirinkimas);

            switch (pasirinkimas)
            {
                case 1:
                    Console.Clear();
                    var naujasProduktas = naujuElementuKurimas.NaujasProduktas();
                    _produktoRepositorija.PridetiProdukta(naujasProduktas);
                    break;
                case 2:
                    Console.Clear();
                    var spausdinimas = new Spausdinimas();
                    spausdinimas.ProduktuSpausdinimas(_produktoRepositorija);
                    var istrinti = new NaujuElementuKurimas();
                    _produktoRepositorija.IstrintiProdukta(istrinti.Istrinti());
                    break;

                default:
                    break;


            }
        }
        public void UzsakymuMenu()

        {
            var naujuElementuKurimas = new NaujuElementuKurimas();
            Console.WriteLine("Pasirinkite Veiksma: \n");
            Console.WriteLine("[1] - Prideti Nauja Uzsakyma");
            Console.WriteLine("[2] - Istrinti Uzsakyma");
            Console.WriteLine("[3] - Grizti");

            int pasirinkimas;
            bool success = int.TryParse(Console.ReadLine(), out pasirinkimas);

            switch (pasirinkimas)
            {
                case 1:
                    Console.Clear();
                    var naujasUzsakymas = naujuElementuKurimas.NaujasUzsakymas();
                    _uzsakymoRepositorija.PridetiUzsakyma(naujasUzsakymas);
                    break;
                case 2:
                    Console.Clear();
                    var spausdinimas = new Spausdinimas();
                    spausdinimas.UzsakymuSpausdinimas(_klientuRepositorija,_produktoRepositorija,_uzsakymoRepositorija);
                    var istrinti = new NaujuElementuKurimas();
                    _uzsakymoRepositorija.IstrintiUzsakyma(istrinti.Istrinti());
                    break;

                default:
                    break;


            }
        }
    }
}
