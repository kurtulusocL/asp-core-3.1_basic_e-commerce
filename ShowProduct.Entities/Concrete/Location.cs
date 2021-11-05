using ShowProduct.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class Location : EntityBase
    {
        public string City { get; set; }
        public string Country { get; set; }

        [Url]
        public string MapUrl { get; set; }
    }
}
