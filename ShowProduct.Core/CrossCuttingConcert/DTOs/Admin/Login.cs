using ShowProduct.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Core.CrossCuttingConcert.DTOs.Admin
{
    public class Login : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
