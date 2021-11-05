﻿using ShowProduct.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class Picture : EntityBase
    {
        public string ImageUrl { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
