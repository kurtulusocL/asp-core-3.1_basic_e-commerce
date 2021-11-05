using ShowProduct.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShowProduct.Core.CrossCuttingConcert.DTOs.Admin
{
    public class SetPassword : IDto
    {
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
