using System;
using System.Collections.Generic;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class UzsakymuAtaskaita
    {
        private KlientuRepositorija _klientuRepositorija;
        private ProduktoRepositorija _produktoRepositorija;
        private UzsakymoRepositorija _uzsakymoRepositorija;

        public UzsakymuAtaskaita(KlientuRepositorija klientuRepositorija, 
                                 ProduktoRepositorija produktoRepositorija, 
                                 UzsakymoRepositorija uzsakymoRepositorija)
        {
            _klientuRepositorija = klientuRepositorija;
            _produktoRepositorija= produktoRepositorija;
            _uzsakymoRepositorija = uzsakymoRepositorija;
        }

        public List<ReportUzsakymas> VisiUzsakymai()
        {
            List<Uzsakymas> uzsakymai = _uzsakymoRepositorija.GetUzsakymas();
            List<ReportUzsakymas> uzsakymuSarasas = new List<ReportUzsakymas>();

            foreach (var uzsakymas in uzsakymai)
            {
                var klientas = _klientuRepositorija.GetKlientas(uzsakymas.KlientoId);
                if (klientas == null)
                {
                    continue;
                }
                var produktas = _produktoRepositorija.GetProduktas(uzsakymas.ProduktoId);
                if (produktas == null)
                {
                    continue;
                }

        ReportUzsakymas report = new ReportUzsakymas();
                report.UzsakymoId = uzsakymas.UzsakymoId;
                report.KlientoVardas = klientas.KlientoVardas;
                report.KlientoPavarde = klientas.KlientoPavarde;
                report.ProduktoId = uzsakymas.ProduktoId;
                report.ProduktoVardas = produktas.ProduktoVardas;
                report.ProkuktoKiekis = uzsakymas.ProduktoKiekis;
                report.VisaSuma = Math.Round(uzsakymas.ProduktoKiekis * produktas.ProduktoKaina,2);

                uzsakymuSarasas.Add(report);
                
            }

            return uzsakymuSarasas;
                
        }

    }
}
