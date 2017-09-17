using System;
using System.Linq;
using System.Collections.Generic;
using CryptoNetWorth.Domain;

namespace CryptoNetWorth.Data
{
    public class CryptoNetWorthDataService : ICryptoNetWorthDataService
    {
        private CryptoNetWorthContext _context;

        public CryptoNetWorthDataService(CryptoNetWorthContext context)
        {
            _context = context;
        }

        public List<DigitalAsset> GetDigitalAssets()
        {
            return _context.DigitalAsset.ToList();
        }

        public DigitalAsset Add(DigitalAsset da)
		{
			_context.DigitalAsset.Add(da);
			_context.SaveChanges();
            return da;
		}
    }
}   
