using ShowProduct.Core.Entities.EntityFramework;
using ShowProduct.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class VideoAd : EntityBase, IVideoAd
    {
        public string CompanyName { get; set; }

        [Url]
        public string VideoUrl { get; set; }

        [Url]
        public string Website { get; set; }
        public DateTime DeleteDate { get; set; }
        public int? Hit { get; set; }
        public void SetHit()
        {
            Hit = 0;
        }
        public VideoAd()
        {
            SetHit();
        }
    }
}
