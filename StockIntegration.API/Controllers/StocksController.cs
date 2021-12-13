using Microsoft.AspNetCore.Mvc;
using StockIntegration.Business;
using StockIntegration.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockIntegration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StocksController(IStockService stockService)
        {
            _stockService = stockService;
        }

        /// <summary>
        /// İlgili varyant için stok bilgilerini verir.
        /// </summary>
        /// <param name="variantCode"></param>
        /// <returns></returns>
        [Route("{variantCode}/variant")]
        [HttpGet]
        public async Task<Stock> GetStockByVariantCode(string variantCode)
        {
            return await _stockService.GetStockByVariant(variantCode);
        }

        /// <summary>
        /// İlgili product için stok bilgilerini verir.
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        [Route("{productCode}/product")]
        [HttpGet]
        public async Task<List<Stock>> GetStockByProductCode(string productCode)
        {
            return await _stockService.GetStockByProduct(productCode);
        }

        /// <summary>
        /// İlgili varyantın stoğunu günceller.
        /// </summary>
        /// <param name="variantCode"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        [Route("{variantCode}")]
        [HttpPut]
        public async Task<Stock> Put(string variantCode, int quantity)
        {
            return await _stockService.UpdateStockByQuantity(variantCode, quantity);
        }

        /// <summary>
        /// İlgili varyant listesini kaydeder.
        /// </summary>
        /// <param name="stock"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Stock> Post([FromBody] Stock stock)
        {
            return await _stockService.CreateStock(stock);
        }
    }
}
