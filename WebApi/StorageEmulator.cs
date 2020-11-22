using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi
{
    public static class StorageEmulator
    {
        public static List<GasolineDto> GasPrices = new List<GasolineDto>()
        {
            new GasolineDto()
            {
                Id = 0,
                Brand = "AI-80",
                Price = 100
            },
            new GasolineDto()
            {
                Id = 1,
                Brand = "AI-92",
                Price = 120
            },
            new GasolineDto()
            {
                Id = 2,
                Brand = "AI-95",
                Price = 150
            },
            new GasolineDto()
            {
                Id = 3,
                Brand = "AI-98",
                Price = 190
            }
        };
    }
}
