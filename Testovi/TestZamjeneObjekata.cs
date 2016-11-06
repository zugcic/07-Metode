using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestZamjeneObjekata : ConsoleTest
    {
        [TestMethod]
        public void ZamjenaObjekata_MetodaZamijeniZamjenjuje2Stringa()
        {
            string prvi = "prvi";
            string drugi = "drugi";
            ZamjenaObjekata.ZamjenaStringova(prvi, drugi);
            Assert.AreEqual("Prije metode Zamijeni:", cw.GetString());
            Assert.AreEqual(string.Format("prvi = '{0}'", prvi), cw.GetString());
            Assert.AreEqual(string.Format("drugi = '{0}'", drugi), cw.GetString());
            Assert.AreEqual("Nakon metode Zamijeni:", cw.GetString());
            Assert.AreEqual(string.Format("prvi = '{0}'", drugi), cw.GetString());
            Assert.AreEqual(string.Format("drugi = '{0}'", prvi), cw.GetString());
        }

        [TestMethod]
        public void ZamjenaObjekata_MetodaZamijeniZamjenjuje2Inta()
        {
            int prvi = 1;
            int drugi = 2;
            ZamjenaObjekata.ZamjenaIntova(prvi, drugi);
            Assert.AreEqual("Prije metode Zamijeni:", cw.GetString());
            Assert.AreEqual(string.Format("prvi = '{0}'", prvi), cw.GetString());
            Assert.AreEqual(string.Format("drugi = '{0}'", drugi), cw.GetString());
            Assert.AreEqual("Nakon metode Zamijeni:", cw.GetString());
            Assert.AreEqual(string.Format("prvi = '{0}'", drugi), cw.GetString());
            Assert.AreEqual(string.Format("drugi = '{0}'", prvi), cw.GetString());
        }
    }
}
