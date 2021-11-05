using ShowProduct.Core.Entities.EntityFramework;
using ShowProduct.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class Ad : EntityBase, IAd
    {
        public string Desc { get; set; }
        public string CompanyName { get; set; }

        [Url]
        public string Website { get; set; }
        public DateTime DeleteDate { get; set; }
        public int? Hit { get; set; }
        public string Photo { get; set; }
        public void SetHit()
        {
            Hit = 0;
        }
        public Ad()
        {
            SetHit();
        }
    }
}
