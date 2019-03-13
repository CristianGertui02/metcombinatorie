using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        [DataRow(20, 2432902008176640000)]
        public void TestFattoriale(int num, long fattorialeAspettato)
        {
            long fattoriale = EquazioniLibrary.CalcoliCombinatori.Fattoriale(num);
            Assert.AreEqual(fattorialeAspettato, fattoriale);
        }
    }
}
