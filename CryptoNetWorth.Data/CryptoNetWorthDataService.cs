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

        public DigitalAsset GetDigitalAsset(string symbol)
        {
            return _context.DigitalAsset.SingleOrDefault(x => x.Symbol == symbol);
        }

        public DigitalAsset Add(DigitalAsset da)
		{
            if (_context.DigitalAsset.Any(x => x.Symbol == da.Symbol))
            {
                _context.DigitalAsset.SingleOrDefault(x => x.Symbol == da.Symbol).Units += da.Units;
            }
            else
            {
                _context.DigitalAsset.Add(da);
            }

			_context.SaveChanges();
            return da;
		}
    }
}   
