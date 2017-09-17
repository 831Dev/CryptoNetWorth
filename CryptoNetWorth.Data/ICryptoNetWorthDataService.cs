using System;
using System.Collections.Generic;
using CryptoNetWorth.Domain;

namespace CryptoNetWorth.Data
{
    public interface ICryptoNetWorthDataService
    {
        List<DigitalAsset> GetDigitalAssets();
        DigitalAsset Add(DigitalAsset da);
    }
}
