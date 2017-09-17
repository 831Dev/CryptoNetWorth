  using System;
using System.Collections.Generic;

namespace CryptoNetWorth.Domain
{
    public class DigitalAsset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double? Units { get; set; }
    }
}
