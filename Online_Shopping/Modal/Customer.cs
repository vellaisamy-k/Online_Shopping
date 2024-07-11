using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Online_Shopping.Modal
{
    public class Customer
    {
        [Key]
        
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string First_Name { get; set; }

        [Required, StringLength(50)]
        public string Last_Name { get; set; }

        [Required, EmailAddress, StringLength(50)]     
        public string Email { get; set; }

        [Required, PasswordPropertyText]
        public string Password { get; set; }

        [Required,StringLength(100)]
        public string Address { get; set; }

        [Required,StringLength(12,ErrorMessage ="Phoe Number should be less than 12 digits")]
        public string Phone_Number { get; set; }

        public ICollection<Shipment> Shipments { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Wishlist> Wishlists { get; set; }
    }

}
