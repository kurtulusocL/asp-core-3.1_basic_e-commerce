using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Core.Entities
{
    public interface IEntity
    {
        void SetDeleted();
        void SetConfirmed();
        void SetCreatedDate();
    }
}
