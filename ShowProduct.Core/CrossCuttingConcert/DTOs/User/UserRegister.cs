using ShowProduct.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShowProduct.Core.CrossCuttingConcert.DTOs.User
{
    public class UserRegister : IDto
    {
        public string NameSurname { get; set; }
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
