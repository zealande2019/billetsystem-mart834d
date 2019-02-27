using BilletSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBil
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPris()
        {
           
            Bil minBil = new Bil("");

            decimal pris = minBil.Pris();

            Assert.AreEqual(240, pris);
        }
       [TestMethod]
            public void TestMethodkøretøj()
            {
                Bil minBil = new Bil("");

                string køretøj = minBil.køretøj();

                Assert.AreEqual("Bil",køretøj);
            }

        [TestMethod]
        public void TestMethodBrobizz()
        {
            Bil minBil = new Bil("");

            double Brobizz = minBil.Brobizz();

            Assert.AreEqual(228, Brobizz);
        }



    }
}
