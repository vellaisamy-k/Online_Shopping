using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Online_Shopping.Modal
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
       
        public DateTime OrderDate { get; set; }

       
        public decimal Total_Price { get; set; }

       
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }


        public int Shipment_Id { get; set; }

   
        public int Payment_Id { get; set; }

      

        public virtual Shipment Shipment { get; set; }       

       public virtual Payment Payment { get; set; }

        public ICollection<Order_Item> OrderItems { get; set; }

    }
}
