using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestMetodeProširenja
    {
        [TestMethod]
        public void MetodaProširenja_MetodaBrojRiječiVraćaBrojRiječiOdvojenihPoJednomBjelinom()
        {
            string s = "udovica baci vodu";
            Assert.AreEqual(3, MetodeProširenja.DajBrojRiječi(s));
        }

        [TestMethod]
        public void MetodaProširenja_MetodaBrojRiječiVraćaBrojRiječiOvojenihSVišestrukimBjelinama()
        {
            string s = "udovica    baci   vodu";
            Assert.AreEqual(3, MetodeProširenja.DajBrojRiječi(s));
        }

        [TestMethod]
        public void MetodaProširenja_MetodaBrojRiječiVraćaBrojRiječiOdvojenihInterpunkcijom()
        {
            string s = "jedan.Dva,tri,četiri";
            Assert.AreEqual(4, MetodeProširenja.DajBrojRiječi(s));
        }

        [TestMethod]
        public void MetodaProširenja_MetodaBrojRiječiVraćaBrojRiječiOdvojenihInterpunkcijomIBjelinama()
        {
            string s = "jedan. Dva, tri, četiri";
            Assert.AreEqual(4, MetodeProširenja.DajBrojRiječi(s));
        }
    }
}
