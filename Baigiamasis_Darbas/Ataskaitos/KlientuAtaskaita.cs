using System;
using System.Collections.Generic;
using System.Text;

namespace Baigiamasis_Darbas
{
    public class KlientuAtaskaita
    {
        private KlientuRepositorija _klientuRepositorija;


        public KlientuAtaskaita(KlientuRepositorija klientuRepositorija)
        {
            _klientuRepositorija = klientuRepositorija;
        }

        public List<ReportKlientas> VisiKlientai()
        {
            List<Klientas> klientai = _klientuRepositorija.GetKlientas();
            List<ReportKlientas> klientuSarasas = new List<ReportKlientas>();

            foreach (var klientas in klientai)
            {
                var report = new ReportKlientas();
                report.KlientoId = klientas.KlientoId;
                report.KlientoVardas = klientas.KlientoVardas;
                report.KlientoPavarde = klientas.KlientoPavarde;

                klientuSarasas.Add(report);
            }
            
            return klientuSarasas;
        }
    }
}
