using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestVirtualnihMetoda : ConsoleTest
    {
        [TestMethod]
        public void VirtualneMetode_ZasebniPoziviNevirtualnihMetodaPozivajuMetodeIzOdgovarajućeKlase()
        {
            VirtualneMetode.ZasebniPoziviNevirtualnihMetoda();
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.AreEqual("Izvedena1 Obično", cw.GetString());
            Assert.AreEqual("Izvedena2 Obično", cw.GetString());
            Assert.IsTrue(cw.IsEmpty);
        }

        [TestMethod]
        public void VirtualneMetode_PoziviNevirtualnihMetodaNaKolekcijiBaznogTipaPozivajuMetodeIzBazneKlase()
        {
            VirtualneMetode.PoziviNevirtualnihMetodaNaKolekcijiBaznogTipa();
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.IsTrue(cw.IsEmpty);
        }

        [TestMethod]
        public void VirtualneMetode_ZasebniPoziviVirtualnihMetodaPozivajuMetodeIzOdogovarajućeKlase()
        {
            VirtualneMetode.ZasebniPoziviVirtualnihMetoda();
            Assert.AreEqual("Bazna Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena1 Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena2 Virtualno", cw.GetString());
            Assert.IsTrue(cw.IsEmpty);
        }

        [TestMethod]
        public void VirtualneMetode_PoziviVirtualnihMetodaNaKolekcijiBaznogTipaPozivajuMetodeIzOdogovarajućeKlase()
        {
            VirtualneMetode.PoziviVirtualnihMetodaNaKolekcijiBaznogTipa();
            Assert.AreEqual("Bazna Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena1 Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena2 Virtualno", cw.GetString());
            Assert.IsTrue(cw.IsEmpty);
        }
    }
}
