using ShowProduct.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class Contact : EntityBase
    {
        public string Email { get; set; }
        public string OptionalEmail { get; set; }
        public string Whatsapp { get; set; }
    }
}
