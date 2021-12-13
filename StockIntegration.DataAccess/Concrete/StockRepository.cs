using Microsoft.EntityFrameworkCore;
using StockIntegration.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockIntegration.DataAccess
{
    public class StockRepository : IStockRepository
    {
        private readonly StockDbContext _stockDbContext;

        public StockRepository()
        {
            _stockDbContext = new StockDbContext();
        }

        public async Task<Stock> GetStockByVariant(string variantCode)
        {
            return await _stockDbContext.Stocks.FindAsync(variantCode);
        }

        public async Task<List<Stock>> GetStockByProduct(string productCode)
        {
            return await _stockDbContext.Stocks.Where(t => t.ProductCode == productCode).ToListAsync();
        }

        public async Task<Stock> UpdateStockByQuantity(string variantCode, int quantity)
        {
            var stock = await GetStockByVariant(variantCode);
            stock.Quantity = quantity;
            _stockDbContext.Stocks.Update(stock);
            await _stockDbContext.SaveChangesAsync();
            return stock;
        }

        public async Task<Stock> CreateStock(Stock stock)
        {
            _stockDbContext.Stocks.Add(stock);
            await _stockDbContext.SaveChangesAsync();
            return stock;
        }

    }
}
