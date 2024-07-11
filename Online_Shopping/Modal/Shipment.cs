using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Shopping.Modal
{
    public class Shipment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Shipment_Date { get; set; }

        [Required,StringLength(100)]
        public string Address { get; set; }

        [Required, StringLength(50)]
        public string City { get; set; }

        [Required, StringLength(50)]
        public string State { get; set; }

        [Required, StringLength(50)]
        public string Country { get; set; }

        [Required, StringLength(10)]
        public string Zip_Code { get; set; }

        [ForeignKey("Customers")]
        public int Customer_Id { get; set; }
        public virtual Customer Customers { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
