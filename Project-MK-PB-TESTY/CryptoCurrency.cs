using System;
using System.Text;
namespace ProjectMKPBTESTY
{
    class CryptoCurrency :ICryptoCurrency
    {
        public CryptoCurrency(int amount, String currency)
        {
            Amount = amount;
            Currency = currency;
        }
        public int Amount { get; }

        public String Currency { get; }

        public override bool Equals(Object anObject)
        {
            if (IsZero)
                if (anObject is ICryptoCurrency)
                    return ((ICryptoCurrency)anObject).IsZero;
            if (anObject is CryptoCurrency)
            {
                CryptoCurrency aCrypto = (CryptoCurrency)anObject;
                return aCrypto.Currency.Equals(Currency)
                    && Amount == aCrypto.Amount;
            }
            return false;
        }

        public bool IsZero
        {
            get { return Amount == 0; }
        }

        public override int GetHashCode()
        {
            return Currency.GetHashCode() + Amount;
        }
        public override String ToString()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("[" + Amount + " " + Currency + "]");
            return buffer.ToString();
        }


        public ICryptoCurrency Add(ICryptoCurrency value) => value.AddCrypto(this);

        public ICryptoCurrency AddCrypto(CryptoCurrency value)
        {
            if (value.Currency.Equals(Currency))
                return new CryptoCurrency(Amount + value.Amount, Currency);
            return new Vault(this, value);
        }

        public ICryptoCurrency AddCryptoVault(Vault v) => v.AddCrypto(this);

        public ICryptoCurrency Multiply(int factor) => new CryptoCurrency(Amount * factor, Currency);

        public ICryptoCurrency Negate() => new CryptoCurrency(-Amount, Currency);

        public ICryptoCurrency Substract(ICryptoCurrency value) => Add(value.Negate());
    }
}
