﻿using System;
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
            Assert.AreEqual(expected, Vault1.Multiply(2));
            Assert.IsTrue(Vault1.Multiply(0).IsZero);
        }

        [Test]
        public void UserCanSubstractVault_ExpectedValueAreEquals_ReturnsTrue()
        {
            CryptoCurrency[] vault = { new CryptoCurrency(-2, "ETH"), new CryptoCurrency(-14, "DBIX") };
            Vault expected = new Vault(vault);
            Assert.AreEqual(expected, Vault1.Substract(Vault2));
        }
        [Test]
        public void UserCanAddVault_ExpectedVauleAreNotEquals_ReturnsTrue()
        {
            CryptoCurrency[] vault = { new CryptoCurrency(14, "ETH"), new CryptoCurrency(7, "DBIX") };
            Vault expected = new Vault(vault);
            Assert.AreNotEqual(expected, Vault1.Add(ETH14));
        }
        [Test]
        public void UserCanNegateVault_ExpectedValuesAreNegative_ReturnsTrue()
        {
            CryptoCurrency[] vault = { new CryptoCurrency(-12, "ETH"), new CryptoCurrency(-7, "DBIX") };
            Vault expected = new Vault(vault);
            Assert.AreEqual(expected, Vault1.Negate());

    }
        [Test]
        public void CheckingIfVaultCanHandleZeros_ExpectedZerosinETHandDBIX_ReturnsTrue()
        {
            Assert.IsTrue(Vault1.Substract(Vault1).IsZero);
            CryptoCurrency[] vault = { new CryptoCurrency(0, "ETH"), new CryptoCurrency(0, "DBIX") };
            Assert.IsTrue(new Vault(vault).IsZero);
        }
        [Test]
        public void CryptoVaultHash_ExpectedValuesSameHashFromNewVaultAsFromSaved_ReturnsTrue()
        {
            Vault equal = new Vault(new CryptoCurrency(12, "ETH"), new CryptoCurrency(7, "DBIX"));
            Assert.AreEqual(Vault1.GetHashCode(), equal.GetHashCode());
        }
        [Test]
        public void JustSimpleTestingPrinting_ReturnsTrue()
        {
            Assert.AreEqual("[12 ETH]", ETH12.ToString());
            Assert.AreEqual("[21 DBIX]", DBIX21.ToString());
        }

    }
}
