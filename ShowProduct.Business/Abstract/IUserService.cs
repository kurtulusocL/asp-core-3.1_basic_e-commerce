using ShowProduct.Business.Abstract.GenericBusinessServices;
using ShowProduct.Core.CrossCuttingConcert.Identities.MicrosoftIdentity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Business.Abstract
{
    public interface IUserService : IEntityBusinessService<ApplicationUser>
    {
        List<ApplicationUser> GetAllUser();
        ApplicationUser GetUserById(string id);
        void SetActive(string id);
        void SetDeActive(string id);
        void Deleted(string id);
        void SetNotDeleted(string id);
    }
}
