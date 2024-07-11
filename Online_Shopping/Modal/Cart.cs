using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Shopping.Modal
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }

        [ForeignKey("Customers")]
        public int Customer_Id { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }

        public virtual Customer Customers { get; set; }

        public virtual Product Products { get; set; }


    }
}
