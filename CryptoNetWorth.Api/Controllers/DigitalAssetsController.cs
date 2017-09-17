using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CryptoNetWorth.Data;
using CryptoNetWorth.Domain;

namespace CryptoNetWorth.Api.Controllers
{
    [Route("api/[controller]")]
    public class DigitalAssetsController : Controller
    {
        private ICryptoNetWorthDataService _dataService;

        public DigitalAssetsController(ICryptoNetWorthDataService cryptoDb)
        {
            _dataService = cryptoDb;
        }

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_dataService.GetDigitalAssets());
		}

        [HttpGet("{id}")]
        public string Get(string id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Post([FromBody]DigitalAsset da)
        {
            return Ok(_dataService.Add(da));
        }
    }
}
