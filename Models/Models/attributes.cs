
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clover_Store.Models
{
    public class attributes
    {
        [Key]
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int ColorID { get; set; }
        public int SizeID { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
      


    }
}
/*

[MaxLength(15, ErrorMessage = "Plase enter correct value"), MinLength(2)]
[DataType(DataType.Text)]
public string LastName { get; set; }
[DataType(DataType.EmailAddress)]
[Required(ErrorMessage = "The Password of User is Required")]//

[DataType(DataType.Password)]
public string Password { get; set; }


[DataType(DataType.PhoneNumber)]
public long Phone { get; set; }



    }
*/
