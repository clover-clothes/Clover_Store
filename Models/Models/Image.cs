using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class Image
    {
        public int Id { get; set; }
        [Required]
        public string Image_url { get; set; }

        
        public int attributId { get; set; }
        [ForeignKey("attributId")]
        
        public attributes attributes { get; set; }
    }
}
