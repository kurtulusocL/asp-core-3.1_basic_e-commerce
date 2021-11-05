using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShowProduct.Core.Entities.EntityFramework
{
    public class EntityBase : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? IsDeletedDate { get; set; }
        public DateTime? LastOperationDate { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsDeleted { get; set; }
        public void SetConfirmed()
        {
            IsConfirmed = true;
        }

        public void SetCreatedDate()
        {
            CreatedDate = DateTime.Now.ToLocalTime();
        }

        public void SetDeleted()
        {
            IsDeleted = false;
        }
        public EntityBase()
        {
            SetConfirmed();
            SetCreatedDate();
            SetDeleted();
        }
    }
}
