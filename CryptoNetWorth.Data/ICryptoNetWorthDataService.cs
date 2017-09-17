using System.Collections.Generic;
using CryptoNetWorth.Domain;

namespace CryptoNetWorth.Data
{
    public interface ICryptoNetWorthDataService
    {
        List<DigitalAsset> GetDigitalAssets();
        DigitalAsset GetDigitalAsset(string symbol);
        DigitalAsset Add(DigitalAsset da);
    }
}
