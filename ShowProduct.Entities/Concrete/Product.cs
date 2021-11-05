using ShowProduct.Core.Entities.EntityFramework;
using ShowProduct.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ShowProduct.Entities.Concrete
{
    public class Product : EntityBase, IProduct, IEquatable<Product>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public decimal Price { get; set; }
        public int? Hit { get; set; }
        public bool IsCommentable { get; set; }
        public bool IsSpecialOffer { get; set; }

        public int CategoryId { get; set; }
        public int SubcategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Subcategory Subcategory { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }

        public void SetHit()
        {
            Hit = 0;
        }

        public void SetCommentable()
        {
            IsCommentable = true;
        }

        public void SetSpecialOffer()
        {
            IsSpecialOffer = false;
        }

        public bool Equals([AllowNull] Product other)
        {
            return Id == other.Id && Name == other.Name && Price == other.Price;
        }

        public Product()
        {
            SetHit();
            SetCommentable();
            SetSpecialOffer();
        }
    }
}
