
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Clover_Store.Models
{
    public class CustomerUsers:IdentityUser
    {

        [Required]
        [MinLength(2, ErrorMessage = "the name must be at least 2 char's"), MaxLength(20, ErrorMessage = "the password must be smaller then 20 char's")]
        public string Full_name { get; set; } = string.Empty;//==


        public string? Adress { get; set; } = string.Empty;//==
        public string? Gender { get; set; } = string.Empty;//male female//==

        public string? Image_url { get; set; }//==

    }
}
