using System;
namespace ProjectMKPBTESTY
{
    interface ICryptoCurrency
    {
        ICryptoCurrency Add(ICryptoCurrency value);
        ICryptoCurrency Multiply(int factor);
        ICryptoCurrency Substract(ICryptoCurrency value);
        ICryptoCurrency Negate();
        ICryptoCurrency AddCrypto(CryptoCurrency value);
        ICryptoCurrency AddCryptoVault(Vault v);
        bool IsZero { get; }
    }
}
