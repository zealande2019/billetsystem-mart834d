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
            public void TestMethodk�ret�j()
            {
                Bil minBil = new Bil("");

                string k�ret�j = minBil.k�ret�j();

                Assert.AreEqual("Bil",k�ret�j);
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
