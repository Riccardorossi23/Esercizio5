using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcolaLibrary.Tests
{
    [TestClass]
    public class TestLibrary
    {
        [TestMethod]
        public void TestRaddoppia1()
        {
            double raddoppia = Calcola.Raddoppia(2);
            Assert.AreEqual(4, raddoppia);
        }
        [TestMethod]
        public void TestRaddoppia2()
        {
            double raddoppia = Calcola.Raddoppia(6);
            Assert.AreEqual(12, raddoppia);
        }
        [TestMethod]
        public void TestRaddoppia3()
        {
            double raddoppia = Calcola.Raddoppia(23);
            Assert.AreEqual(46, raddoppia);
        }
        [DataTestMethod]
        [DataRow(24, 48)]
        [DataRow(60, 120)]
        [DataRow(5, 10)]
        [DataRow(3.5, 7)]
        public void DataTestRaddoppia(double numero, double risposta_aspettata)
        {
            double raddoppia = Calcola.Raddoppia(numero);
            Assert.AreEqual(risposta_aspettata, raddoppia);
        }
        [TestMethod]
        public void Testmonete1()
        {
            double[] monete = new double[] { 3.5, 4, 5.8, 6 };
            double risposta_aspettata = 19.3;
            double sommamonete = Calcola.SommaMonete(monete);
            Assert.AreEqual(risposta_aspettata, sommamonete);
        }
        [TestMethod]
        public void Testmonete2()
        {
            double[] monete = new double[] { 5, 14, 28, 46 };
            double risposta_aspettata = 93;
            double sommamonete = Calcola.SommaMonete(monete);
            Assert.AreEqual(risposta_aspettata, sommamonete);
        }
        [TestMethod]
        public void Testmonete3()
        {
            double[] monete = new double[] { 5.6, 14.12, 8.5, 67 };
            double risposta_aspettata = 95.22;
            double sommamonete = Calcola.SommaMonete(monete);
            Assert.AreEqual(risposta_aspettata, sommamonete);
        }
    }
}
