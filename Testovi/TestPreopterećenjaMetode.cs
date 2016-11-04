using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestPreopterećenjaMetode : ConsoleTest
    {
        [TestMethod]
        public void Preopterećenje_PozivSArgumentimaDoubleDoublePozivaMetoduSArgumentimaDoubleDouble()
        {
            double d1 = 1.2;
            double d2 = 3.4;
            Preopterećenje.MojaMetoda(d1, d2);
            Assert.AreEqual(string.Format("MojaMetoda(double {0}, double {1})", d1, d2), cw.GetString());
        }

        [TestMethod]
        public void Preopterećenje_PozivSArgumentimaIntIntPozivaMetoduSParametrimaIntDouble()
        {
            int i1 = 1;
            int i2 = 2;
            Preopterećenje.MojaMetoda(i1, i2);
            Assert.AreEqual(string.Format("MojaMetoda(int {0}, double {1})", i1, i2), cw.GetString());
        }

        [TestMethod]
        public void Preopterećenje_PozivSArgumentimaIntDoublePozivaMetoduSArgumentimaIntDouble()
        {
            int i1 = 1;
            double d2 = 3.4;
            Preopterećenje.MojaMetoda(i1, d2);
            Assert.AreEqual(string.Format("MojaMetoda(int {0}, double {1})", i1, d2), cw.GetString());
        }

        [TestMethod]
        public void Preopterećenje_PozivSArgumentimaDoubleIntPozivaMetoduSArgumentimaDoubleDouble()
        {
            double d1 = 3.4;
            int i2 = 1;
            Preopterećenje.MojaMetoda(d1, i2);
            Assert.AreEqual(string.Format("MojaMetoda(double {0}, double {1})", d1, i2), cw.GetString());
        }
    }
}
