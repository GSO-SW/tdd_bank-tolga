using Bank;
namespace BankTest
{

    [TestClass]

    public class KontoTests

    {
        [TestMethod]

        public void KontoNr_KannAbgefragtWerden()

        {

            // Arrange 

            Konto k = new Konto(0);

            int nummer_soll = 1;

            // Act 

            int nummer_ist = k.KontoNr;

            //Arrange 

            Assert.AreEqual(nummer_soll, nummer_ist);

        }

        [TestMethod]
        public void KontoNr_WirdAutomatischVergeben()

        {

            // Arrange 

            Konto k1 = new Konto(0);

            Konto k2 = new Konto(0);

            Konto k3 = new Konto(0);

            int kontoNummer_soll = 3;

            // Act 

            int kontoNummer_ist = k3.KontoNr;

            // Assert 

            Assert.AreEqual(kontoNummer_soll, kontoNummer_ist);

        }
    }
}
