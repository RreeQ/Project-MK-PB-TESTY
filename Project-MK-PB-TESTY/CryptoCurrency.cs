using System;
using System.Text;
namespace ProjectMKPBTESTY
{
    public class CryptoCurrency: ICryptoCurrency
    {
        public CryptoCurrency(int amount, String currency)
        {
            Amount = amount;
            Currency = currency;
        }
        public int Amount { get; }

        public String Currency { get; }

        public bool isZero => throw new NotImplementedException();

        public ICryptoCurrency Add(ICryptoCurrency value)
        {
            throw new NotImplementedException();
        }

        public ICryptoCurrency AddCrypto(CryptoCurrency c)
        {
            throw new NotImplementedException();
        }

        public ICryptoCurrency AddCryptoVault(Vault v)
        {
            throw new NotImplementedException();
        }

        public ICryptoCurrency Multiply(ICryptoCurrency value)
        {
            throw new NotImplementedException();
        }

        public ICryptoCurrency Negate()
        {
            throw new NotImplementedException();
        }

        public ICryptoCurrency Substract(ICryptoCurrency value)
        {
            throw new NotImplementedException();
        }
    }
}
