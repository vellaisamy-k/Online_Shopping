using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Online_Shopping.Modal
{
    public class Order_Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }

        [ForeignKey("Orders")]
        public int Order_Id { get; set; }

        [ForeignKey("Products")]
        public int Product_Id { get; set; }

        public virtual Order Orders { get; set; }

        public virtual Product Products { get; set; }
    }
}
