 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace Shop.entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
