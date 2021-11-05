using ShowProduct.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class ProductDetail : EntityBase
    {
        public string Desc { get; set; }
        public string Detail { get; set; }
        public string Warning { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
