using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Shopping.Modal
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(100)]
        public string SKU { get; set; }
        [Required, StringLength(100)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }

        [ForeignKey("Categorys")]
        public int Category_Id { get; set; }

        public virtual Category Categorys { get; set; }

        public ICollection<Order_Item> Order_Items { get; set; }

        public ICollection<Cart> Carts { get; set; }

        public ICollection<Wishlist> Wishlists { get; set; } = new HashSet<Wishlist>();


    }
}
