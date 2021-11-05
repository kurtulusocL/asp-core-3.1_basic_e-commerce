using ShowProduct.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class Tag : EntityBase
    {
        public string Name { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
