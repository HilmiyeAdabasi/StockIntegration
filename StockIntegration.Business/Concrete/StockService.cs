using StockIntegration.DataAccess;
using StockIntegration.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockIntegration.Business
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public async Task<Stock> GetStockByVariant(string variantCode)
        {
            return await _stockRepository.GetStockByVariant(variantCode);
        }

        public async Task<List<Stock>> GetStockByProduct(string productCode)
        {
            return await _stockRepository.GetStockByProduct(productCode);
        }

        public async Task<Stock> UpdateStockByQuantity(string variantCode, int quantity)
        {
            return await _stockRepository.UpdateStockByQuantity(variantCode, quantity);
        }

        public async Task<Stock> CreateStock(Stock stock)
        {
            return await _stockRepository.CreateStock(stock);
        }

    }
}
