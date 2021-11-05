using ShowProduct.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Core.CrossCuttingConcert.DTOs.User
{
    public class UserLogin : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
