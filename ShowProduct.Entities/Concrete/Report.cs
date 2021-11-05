using ShowProduct.Core.Entities.EntityFramework;
using ShowProduct.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class Report : EntityBase, IReport
    {
        public string NameSuname { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public bool IsFixed { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }

        public void SetFixed()
        {
            IsFixed = false;
        }
        public Report()
        {
            SetFixed();
        }
    }
}
