using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QuinzeEStUnMultipleDeTrois()
        {
            const int NOMBRE = 15;
            string resultat = string.Empty;

            resultat = Program.MultipleDeTrois(NOMBRE);

            Assert.AreEqual("Fizz", resultat);
        }
    }
}
