using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestRefParametar
    {
        [TestMethod]
        public void RefParametar_MetodaDodajDesetUvećavaProslijeđeniCijeliBroj()
        {
            Assert.AreEqual(15, RefParametar.PozivMetodeDodajDeset(5));
        }

        [TestMethod]
        public void RefParametar_MetodaPromijeniOsobuDoistaMijenjaProsljeđenuOsobu()
        {
            RefParametar.Osoba novaOsoba = RefParametar.PozivMetodePromijeniOsobu(new RefParametar.Osoba("Janko", 1), "Pero", 12);
            Assert.AreEqual("Pero", novaOsoba.Ime);
            Assert.AreEqual(12, novaOsoba.MatičniBroj);
        }
    }
}
