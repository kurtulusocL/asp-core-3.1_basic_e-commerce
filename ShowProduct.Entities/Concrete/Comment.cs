using ShowProduct.Core.Entities.EntityFramework;
using ShowProduct.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class Comment : EntityBase, IComment
    {
        public string NameSuname { get; set; }
        public string EMailAddress { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public int? Hit { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }

        public void SetHit()
        {
            Hit = 0;
        }
        public Comment()
        {
            SetHit();
        }
    }
}
