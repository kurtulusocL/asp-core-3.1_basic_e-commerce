using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Core.CrossCuttingConcert.DTOs.Entities.UpdateModels
{
    public class ProductPriceUpdate
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int? ProductId { get; set; }
    }
}
