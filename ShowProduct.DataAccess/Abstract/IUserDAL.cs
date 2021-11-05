using ShowProduct.Core.CrossCuttingConcert.Identities.MicrosoftIdentity;
using ShowProduct.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.DataAccess.Abstract
{
    public interface IUserDAL : IEntityRepository<ApplicationUser>
    {       
        ApplicationUser GetUserById(string id);
        void SetActive(string id);
        void SetDeActive(string id);
        void Deleted(string id);
        void SetNotDeleted(string id);
    }
}
