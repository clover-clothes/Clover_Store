
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ MinLength(3,ErrorMessage ="please enter a valide name")]
        public string Card_name { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.CreditCard)]
        [MaxLength(16, ErrorMessage = "Plase enter a valide card number"), MinLength(14, ErrorMessage = "Plase enter correct value")]
        public string Card_number { get; set; } = string.Empty;
        [Required]
        [MaxLength(3, ErrorMessage = "Plase enter a valide CVC number,Must be 3 numbers"), MinLength(3)]
        public string Card_CVC { get; set; } = string.Empty;
        [Required]

        [Column(TypeName = "Date")]
        public DateTime EXdate { get; set; }
        


    }
}
