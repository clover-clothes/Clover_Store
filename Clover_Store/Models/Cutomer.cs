
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Clover_Store.Models
{
    public class Cutomer
    {
        [Key]
        public int Id { get; set; }
        public string Full_name { get; set; } = string.Empty;
        public string User_name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        
        [DataType(DataType.Password)]
        [MinLength(8),MaxLength(24)]
        public string Password { get; set; } = string.Empty;
        public string  Adress { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;//male female
        public string Phon_number { get; set; } = string.Empty;
       
        [DataType(DataType.DateTime)]
        public DateTime Log_date { get; set; }
        [Column(TypeName = "Image")]
        public byte[]? Profile_image { get; set; }

    }
}
