using Microsoft.AspNetCore.Identity;
using ShowProduct.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Core.CrossCuttingConcert.Identities.MicrosoftIdentity
{
    public class ApplicationUser : IdentityUser, IEntity
    {
        public string NameSurname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
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
        public ApplicationUser()
        {
            SetDeleted();
            SetCreatedDate();
            SetConfirmed();
            EmailConfirmed = true;
            PhoneNumberConfirmed = true;
        }
    }
}
