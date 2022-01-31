using System;
using System.Collections.Generic;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class ProduktuAtaskaita
    {
        private ProduktoRepositorija _produktoRepositorija;


        public ProduktuAtaskaita(ProduktoRepositorija produktoRepositorija)
        {
            _produktoRepositorija = produktoRepositorija;
        }

        public List<ReportProduktas> VisiProduktai()
        {
            List<Produktas> produktai = _produktoRepositorija.GetProduktas();
            List<ReportProduktas> produktuSarasas = new List<ReportProduktas>();

            foreach (var produktas in produktai)
            {
                var report = new ReportProduktas();
                report.ProduktoId = produktas.ProduktoId;
                report.ProduktoVardas = produktas.ProduktoVardas;
                report.ProduktoKaina = produktas.ProduktoKaina;

                produktuSarasas.Add(report);
            }

            return produktuSarasas;
        }
    }
}
