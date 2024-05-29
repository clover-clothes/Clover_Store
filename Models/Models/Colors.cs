
﻿using System.ComponentModel.DataAnnotations;

namespace Clover_Store.Models
{
    public class Colors
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(0,255)]
        public int Red {  get; set; }
        [Required]
        [Range(0, 255)]
        public int Green { get; set; }
        [Required]
        [Range(0, 255)]
        public int Blue { get; set; }


    }
}