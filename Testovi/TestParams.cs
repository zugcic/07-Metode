using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestParams
    {
        [TestMethod]
        public void Params_MetodaZbrojiZaSamoJedanArgumentVraćaTajBroj()
        {
            Assert.AreEqual(1, Params.Zbroji(1));
        }

        [TestMethod]
        public void Params_MetodaZbrojiZaDvaArgumentVraćaNjihovZbroj()
        {
            Assert.AreEqual(3, Params.Zbroji(1, 2));
        }

        [TestMethod]
        public void Params_MetodaZbrojiZaProizvolniBrojArgumenataVraćaNjihovZbroj()
        {
            Assert.AreEqual(15, Params.Zbroji(1, 2, 3, 4, 5));
        }
    }
}
