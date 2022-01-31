using System;
using System.Collections.Generic;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class Spausdinimas
    {
        public void UzsakymuSpausdinimas(KlientuRepositorija klientuRepositorija, ProduktoRepositorija produktoRepositorija, UzsakymoRepositorija uzsakymoRepositorija)
        {
            var uzsakymuAtaskaita = new UzsakymuAtaskaita(klientuRepositorija, produktoRepositorija, uzsakymoRepositorija);

            List<ReportUzsakymas> visiUzsamymai = uzsakymuAtaskaita.VisiUzsakymai();

            Console.WriteLine("Visi Uzsakymai: \n");
            foreach (var uzsakymas in visiUzsamymai)
            {
                Console.WriteLine($"Uzsakymo ID: {uzsakymas.UzsakymoId}| " +
                    $" Klientas: {uzsakymas.KlientoVardas} {uzsakymas.KlientoPavarde}| " +
                    $"isigyjo: {uzsakymas.ProduktoVardas}| " +
                    $"kiekis:{uzsakymas.ProkuktoKiekis}| " +
                    $"galutine kaina: {uzsakymas.VisaSuma}$");
            }
            Console.WriteLine();

        }

        public void KlientuSpausdinimas(KlientuRepositorija klientuRepositorija)
        {
            var klientuAtaskaita = new KlientuAtaskaita(klientuRepositorija);

            List<ReportKlientas> visiKlientai = klientuAtaskaita.VisiKlientai();

            Console.WriteLine("Visi Klientai: \n");

            foreach (var klientas in visiKlientai)
            {
                Console.WriteLine($"Kliento ID: {klientas.KlientoId}| " +
                    $"Vardas Pavarde: {klientas.KlientoVardas} " +
                    $"{klientas.KlientoPavarde}");
            }
            Console.WriteLine();
        }

            public void ProduktuSpausdinimas(ProduktoRepositorija produktoRepositorija)
            {
                var produktuAtaskaita = new ProduktuAtaskaita(produktoRepositorija);

                List<ReportProduktas> visiProduktai = produktuAtaskaita.VisiProduktai();

                Console.WriteLine("Visi Produktai: \n");

                foreach (var produktas in visiProduktai)
                {
                    Console.WriteLine($"Produkto ID: {produktas.ProduktoId}| " +
                        $"Produkto Pavadinimas: {produktas.ProduktoVardas}| " +
                        $"Produkto Kaina :{produktas.ProduktoKaina}$");
                }
                Console.WriteLine();

            }
        }
}
