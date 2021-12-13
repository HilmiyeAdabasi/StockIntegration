using StockIntegration.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockIntegration.DataAccess
{
    public interface IStockRepository
    {
        Task<Stock> GetStockByVariant(string variantCode);
        Task<List<Stock>> GetStockByProduct(string productCode);
        Task<Stock> UpdateStockByQuantity(string variantCode, int quantity);
        Task<Stock> CreateStock(Stock stock);

    }
}
