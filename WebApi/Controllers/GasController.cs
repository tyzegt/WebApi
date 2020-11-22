using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("{controller}/{action}")]
    public class GasController : Controller
    {
        private readonly GasService _gasService;

        public GasController(GasService gasService)
        {
            _gasService = gasService;
        }

        [HttpGet]
        public async Task<IEnumerable<GasolineDto>> Prices()
        {
            return await _gasService.GetPrices();
        }

        [HttpPost]
        public async Task<PriceDto> CalculatePrice(int? brandId, int liters)
        {
            return await _gasService.CalculatePrice((int)brandId, liters);
        }
    }
}
