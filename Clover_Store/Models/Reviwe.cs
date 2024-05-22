using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class Reviwe
    {
        [Key]
        public int Id { get; set; }
        public string? Comment { get; set; } = string.Empty;
        public int ProductID { get; set; }
        public int CusomerID { get; set; }
        public int Rank { get; set; } //5/5
        [Column(TypeName = "Date")]
        public DateTime DateTime { get; set; }
    }
}
