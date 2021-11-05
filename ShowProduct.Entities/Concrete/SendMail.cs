using ShowProduct.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class SendMail : EntityBase
    {
        [EmailAddress]
        public string RecieverEMail { get; set; }

        [EmailAddress]
        public string SenderEMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
