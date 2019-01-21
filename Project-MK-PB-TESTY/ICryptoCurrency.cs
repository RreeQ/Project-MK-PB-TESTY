using System;
namespace ProjectMKPBTESTY
{
    public interface ICryptoCurrency
    {
        ICryptoCurrency Add(ICryptoCurrency value);
        ICryptoCurrency Multiply(ICryptoCurrency value);
        ICryptoCurrency Substract(ICryptoCurrency value);
        ICryptoCurrency Negate();

        ICryptoCurrency AddCrypto(CryptoCurrency c);
        ICryptoCurrency AddCryptoVault(Vault v);

        bool isZero { get; }

        


    }
}
