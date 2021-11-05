using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Entities.Abstract
{
    public interface IProduct
    {
        void SetHit();
        void SetCommentable();
        void SetSpecialOffer();
    }
}
