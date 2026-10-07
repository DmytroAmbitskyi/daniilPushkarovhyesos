namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Produkt_SprawdzWartoscMagazynu()
        {
            var produkt = new ConsoleApp1.Produkt
            {
                name = "TestProdukt",
                price = 10.0,
                category = "TestKategoria",
                count = 5,

            };
            double wartoscMagazynu = produkt.wartoscmagazynu;

            Assert.AreEqual(50.0, wartoscMagazynu, "Wartosc magazynu powinna byc rowna Cena * Ilosc: ");
        }
    }
}
