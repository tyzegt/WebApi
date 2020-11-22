using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public class GasService
    {
        public async Task<IEnumerable<GasolineDto>> GetPrices()
        {            
            return StorageEmulator.GasPrices;
        }


        public async Task<PriceDto> CalculatePrice(int brandId, int liters)
        {
            try
            {
                return new PriceDto() { 
                    Price = StorageEmulator.GasPrices
                        .FirstOrDefault(x => x.Id == brandId)
                        .Price * liters 
                };
            } 
            catch
            {
                return null;
            }
        }
    }
}
