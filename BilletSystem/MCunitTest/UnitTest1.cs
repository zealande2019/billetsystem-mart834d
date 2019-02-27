using BilletSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MCunitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void TestMethodPris()
            {

                MC minMC = new MC("");

                decimal pris = minMC.Pris();

                Assert.AreEqual(125, pris);
            }
            [TestMethod]
            public void TestMethodk�ret�j()
            {
                MC minMC = new MC("");

                string k�ret�j = minMC.k�ret�j();

                Assert.AreEqual("MC", k�ret�j);
            }
        [TestMethod]
        public void TestMethodBrobizz()
        {
            MC minMC = new MC("");

            double Brobizz = minMC.Brobizz();

            Assert.AreEqual(228, Brobizz);
        }
    }
 }

