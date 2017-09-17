using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
            try
            {
                return Ok(_dataService.GetDigitalAssets());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
		}

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(_dataService.GetDigitalAsset(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]DigitalAsset da)
        {
            return Ok(_dataService.Add(da));
        }
    }
}
