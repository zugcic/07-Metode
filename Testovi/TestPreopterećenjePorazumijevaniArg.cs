using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestPreopterećenjePorazumijevaniArg
    {
        [TestMethod]
        public void PreopterećenjePorazumijevaniArg_ZaPoziveSDvaArgumentaSeIzvodiPreopterećenaMetodaSDvaArgumenta()
        {
            Assert.AreEqual(11, PreopterećenjePorazumijevaniArg.Zbroji(5, 6));
            Assert.AreEqual(1, PreopterećenjePorazumijevaniArg.Zbroji(1, 0));
        }

        [TestMethod]
        public void PreopterećenjePorazumijevaniArg_ZaPoziveSJednimArgumentomSeIzvodiPreopterećenaMetodaSTriArgumentaSPodrazumijevanimVrijednostima()
        {
            Assert.AreEqual(10, PreopterećenjePorazumijevaniArg.Zbroji(5));
            Assert.AreEqual(6, PreopterećenjePorazumijevaniArg.Zbroji(1));
        }

        [TestMethod]
        public void PreopterećenjePorazumijevaniArg_ZaPoziveSTriArgumentaSeIzvodiPreopterećenaMetodaSTriArgumentaSPodrazumijevanimVrijednostima()
        {
            Assert.AreEqual(35, PreopterećenjePorazumijevaniArg.Zbroji(5, 10, 20));
            Assert.AreEqual(3, PreopterećenjePorazumijevaniArg.Zbroji(1, 1, 1));
        }
    }
}
