using System;
using NUnit.Framework;

namespace ProjectMKPBTESTY
{

    [TestFixture]
    public class Testy
    {
        //ETH - ETHEREUM
        //DBIX - Dubaicoin

        private CryptoCurrency ETH12;
        private CryptoCurrency ETH14;
        private CryptoCurrency DBIX7;
        private CryptoCurrency DBIX21;

        private Vault Vault1;
        private Vault Vault2;

        [SetUp]
        protected void SetUp()
        {
            ETH12 = new CryptoCurrency(12, "ETH");
            ETH14 = new CryptoCurrency(14, "ETH");
            DBIX7 = new CryptoCurrency(7, "DBIX");
            DBIX21 = new CryptoCurrency(21, "DBIX");

            Vault1 = new Vault(ETH12, DBIX7);
            Vault2 = new Vault(ETH14, DBIX21);

        }
        [Test]
        public void UserCanMultiplyVault_ReturnsTrue()
        {
            CryptoCurrency[] vault = { new CryptoCurrency(24, "ETH"), new CryptoCurrency(14, "DBIX") };
            Vault expected = new Vault(vault);
            Assert.AreEqual(expected, Vault1.Multiply(3));
            Assert.AreEqual(Vault1, Vault1.Multiply(2));
            Assert.IsTrue(Vault1.Multiply(0).IsZero);
        }

        [Test]
        public void UserCanSubstractVault_ReturnsExpectedValueAreEquals()
        {
            CryptoCurrency[] vault = { new CryptoCurrency(-2, "ETH"), new CryptoCurrency(-14, "DBIX") };
            Vault expected = new Vault(vault);
            Assert.AreEqual(expected, Vault1.Substract(Vault2));
        }

    }
}
