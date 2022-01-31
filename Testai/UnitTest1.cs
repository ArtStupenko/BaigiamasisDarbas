using Baigiamasis_Darbas;
using NUnit.Framework;

namespace Testai
{
    public class Tests
    {

        [Test]
        public void KlientasPagalID()
        {
            //arrange
            var klientoRepositorija = new KlientuRepositorija();
            string vardas = "Kajus";
            //act
            var actualResult = klientoRepositorija.GetKlientas(1);
            //assert
            Assert.AreEqual(vardas, actualResult.KlientoVardas);

        }
        [Test]
        public void ProduktasPagalID()
        {
            var produktas = new ProduktoRepositorija();
            string vardas = "Sultys";

            var result = produktas.GetProduktas(3);

            Assert.AreEqual(vardas, result.ProduktoVardas);
        }
        [Test]

        public void UzsakymasPagalID()
        {
            var uzsakymas = new UzsakymoRepositorija();
            int kiekis = 30;

            var result = uzsakymas.GetUzsakymas(3);

            Assert.AreEqual(kiekis, result.ProduktoKiekis);
        }
    }
}