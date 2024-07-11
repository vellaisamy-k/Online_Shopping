using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Shopping.Modal
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Payment_Date { get; set; }

        [Required,StringLength(100)]
        public string Payment_Method { get; set; }
        [Required]
        public decimal Amount { get; set; }


        [ForeignKey("Customers")]
        public int Customer_Id { get; set; }

        public virtual Customer Customers { get; set; }

        public ICollection<Order> Orders { get; } = new List<Order>();
    }
}
