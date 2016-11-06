using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestModifikatoraNew : ConsoleTest
    {
        [TestMethod]
        public void ModifikatorNew_PozivMetodePredstaviSeNaBaznojKlasiPozivaMetoduIzBazne()
        {
            ModifikatorNew.Bazna bazna = new ModifikatorNew.Bazna();
            bazna.PredstaviSe();
            Assert.AreEqual("Bazna klasa", cw.GetString());
        }

        [TestMethod]
        public void ModifikatorNew_PozivMetodePredstaviSeNaIzvedenojKlasiPridruženojBaznomTipuPozivaMetoduIzBazne()
        {
            ModifikatorNew.Bazna bazna = new ModifikatorNew.Izvedena();
            bazna.PredstaviSe();
            Assert.AreEqual("Bazna klasa", cw.GetString());
        }

        [TestMethod]
        public void ModifikatorNew_PozivMetodePredstaviSeNaIzvedenojKlasiPozivaMetoduIzIzvedene()
        {
            ModifikatorNew.Izvedena izvedena = new ModifikatorNew.Izvedena();
            izvedena.PredstaviSe();
            Assert.AreEqual("Izvedena klasa, izvedena iz:", cw.GetString());
            Assert.AreEqual("Bazna klasa", cw.GetString());
        }
    }
}
