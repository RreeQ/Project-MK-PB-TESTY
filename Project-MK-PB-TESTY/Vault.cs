using System;
using System.Collections;
using System.Text;
namespace ProjectMKPBTESTY
{
    public class Vault : ICryptoCurrency
    {
        private ArrayList CryptoCurrencies = new ArrayList(5);

        private Vault()
        {

        }
        public Vault(CryptoCurrency c1, CryptoCurrency c2)
        {
            AppendCrypto(c1);
            AppendCrypto(c2);
        }
        public Vault(CryptoCurrency c1, Vault v)
        {
            AppendCrypto(c1);
            AppendVault(v);
        }
        public Vault(Vault v1, Vault v2)
        {
            AppendVault(v1);
            AppendVault(v2);
        }
        public Vault(CryptoCurrency[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if(!v[i].isZero)
                {
                    AppendCrypto(v[i]);
                }
            }
        }

        public bool isZero => throw new NotImplementedException();

        public ICryptoCurrency Add(ICryptoCurrency value)
        {
            return value.AddCryptoVault(this);
        }

        public ICryptoCurrency AddCrypto(CryptoCurrency c)
        {
            return (new Vault(c, this)).Simplify();
        }

        public ICryptoCurrency AddCryptoVault(Vault v)
        {
            return (new Vault(v, this)).Simplify();
        }

        public ICryptoCurrency Multiply(int factor)
        {
            Vault result = new Vault();
            if (factor != 0)
            {
                foreach (CryptoCurrency c in Cryptos)
                {
                    result.AppendCrypto((CryptoCurrency)c.Multiply(factor));
                }
            }
            return result;
        }

        public ICryptoCurrency Negate()
        {
            Vault result = new Vault();
            foreach (CryptoCurrency c in Cryptos)
            {
                result.AppendCrypto((CryptoCurrency)c.Negate());
            }
            return result;
        }

        public ICryptoCurrency Substract(ICryptoCurrency c )
        {
            return Add(c.Negate());
        }
        private ICryptoCurrency Simplify()
        {
            if (Cryptos.Count == 1)
                return (ICryptoCurrency)Cryptos[0];
            return this;
        }
        
        public ICryptoCurrency Substract(ICryptoCurrency c)
        {
            return Add(c.Negate());
        }
        public override String ToString()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("{");
            foreach (CryptoCurrency m in Cryptos)
                buffer.Append(m);
            buffer.Append("}");
            return buffer.ToString();
        }
        public bool IsZero
        {
            get { return Cryptos.Count == 0; }
        }
        private void AppendVault(Vault v)
        {
            foreach (CryptoCurrency c in v.Cryptos)
            {
                AppendCrypto(c);
            }
        }
        private void AppendCrypto(CryptoCurrency c)
        {
            ICryptoCurrency old = FindCrypto(c.Currency);
            if (old == null)
            {
                Cryptos.Add(c);
                return;

            }
            Cryptos.Remove(old);
            ICryptoCurrency sum = old.Add(c);
            if (sum.isZero)
            {
                return;
            }
            Cryptos.Add(sum);
        }
        private bool Contains(CryptoCurrency c)
        {
            CryptoCurrency crypto = FindCrypto(c.Currency);
            return crypto.Amount == c.Amount;
        }
        public override bool Equals(Object anObject)
        {
            if (IsZero)
                if (anObject is ICryptoCurrency)
                    return ((ICryptoCurrency)anObject).isZero;

            if (anObject is Vault)
            {
                Vault v = (Vault)anObject;
                if (v.Cryptos.Count != Cryptos.Count)
                    return false;

                foreach (CryptoCurrency c in Cryptos)
                {
                    if (!v.Contains(c))
                        return false;
                }
                return true;
            }
            return false;
        }
        private CryptoCurrency FindCrypto(String currency)
        {
            foreach (CryptoCurrency c in Cryptos)
            {
                if (c.Currency.Equals(currency))
                    return c;
            }
            return null;
        }

    }
}
