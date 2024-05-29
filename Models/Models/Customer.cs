
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Clover_Store.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "the name must be at least 2 char's"), MaxLength(20, ErrorMessage = "the password must be smaller then 20 char's")]
        public string Full_name { get; set; } = string.Empty;
        public string? User_name { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="the password must be at least 8 char's"),MaxLength(24, ErrorMessage = "the password must be smaller then 24 char's")]
        public string Password { get; set; } = string.Empty;
        
        public string  Adress { get; set; } = string.Empty;
        public string? Gender { get; set; } = string.Empty;//male female
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Phon_number { get; set; } = string.Empty;
       
        [DataType(DataType.DateTime)]
        public DateTime Log_date { get; set; }
       
        public string? Image_url { get; set; }

    }
}
