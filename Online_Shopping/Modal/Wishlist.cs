using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Shopping.Modal
{
    public class Wishlist
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customers")]
        public int Customer_Id { get; set; }

        [ForeignKey("Products")]
        public int Product_Id { get; set; }

        public virtual Customer Customers { get; set; }

        public virtual Product Products { get; set; }
    }
}
