using ShowProduct.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class SocialMedia : EntityBase
    {
        public string Name { get; set; }

        [Url]
        public string Url { get; set; }
        public string Logo { get; set; }
    }
}
