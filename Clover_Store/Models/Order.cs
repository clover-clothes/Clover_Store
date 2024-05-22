using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Order_date { get; set; }
        public int Customer { get; set; }
        public int CardID { get; set; }
        public string City { get; set; } = string.Empty;
        public string Zip_code { get; set; } = string.Empty;
        [Column(TypeName = "decimal(10,2)")]
        public decimal Total_price { get; set; }
    }
}

