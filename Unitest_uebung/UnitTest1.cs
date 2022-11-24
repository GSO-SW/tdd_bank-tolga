using Bank;

namespace Unitest_uebung
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Konto_ErstellenMitStartKapital()
        {
            //arrange
            int guthaben = 10;

            //act
            Konto k1 = new Konto(guthaben);

            //assert
            Assert.AreEqual(k1.Guthaben, 10);

        }

        [TestMethod]
        public void Konto_Einzahlen()
        {
            //arrange
            Konto k1 = new Konto(10);

            //act
            k1.Einzahlen(100);

            //assert
            Assert.AreEqual(k1.Guthaben, 110);
        }

        [TestMethod]
        public void Konto_Auszahlen()
        {
            //arrange
            Konto k1 = new Konto(10);

            //act
            k1.Auszahlen(5);

            //assert
            Assert.AreEqual(k1.Guthaben, 5);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Konto_EinzahlenNegativ()
        {
            //arrange
            Konto k1 = new Konto(10);

            //act
            k1.Einzahlen(100);

            //assert
            Assert.AreEqual(k1.Guthaben, 100);
        }
    }
}