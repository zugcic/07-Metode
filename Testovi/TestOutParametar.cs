using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestOutParametar : ConsoleTest
    {
        [TestMethod]
        public void OutParametar_InicijalizirajBrojNaDesetPostavljaArgumentNa10()
        {
            OutParametar.PozivInicijalizacijeOutParametrom();
            Assert.AreEqual("Nakon InicijalizirajBrojNaDeset: 10", cw.GetString());
        }
    }
}
