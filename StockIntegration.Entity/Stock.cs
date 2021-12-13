using System;
using System.ComponentModel.DataAnnotations;

namespace StockIntegration.Entity
{
    public class Stock
    {
        [Key]
        public string VariantCode { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
