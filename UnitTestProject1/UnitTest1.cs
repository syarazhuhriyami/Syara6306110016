using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPenjumlahan()
        {
            MainWindow main = new MainWindow();
            double result = main.Penjumlahan(1, 2);
            double expected = 3;

            Assert.AreEqual(result, expected, "Maaf SALAH");
        }

        [TestMethod]
        public void TestPengurangan()
        {
            MainWindow main = new MainWindow();
            double result = main.Pengurangan(1, 2);
            double expected = 1;

            Assert.AreEqual(result, expected, "Maaf SALAH");
        }

        [TestMethod]
        public void TestPerkalian()
        {
            MainWindow main = new MainWindow();
            double result = main.Perkalian(1, 2);
            double expected = 2;

            Assert.AreEqual(result, expected, "Maaf SALAH");
        }

        [TestMethod]
        public void TestPembagian()
        {
            MainWindow main = new MainWindow();
            double result = main.Pembagian(3, 9);
            double expected = 3;

            Assert.AreEqual(result, expected, "Maaf SALAH");
        }
    }
}
