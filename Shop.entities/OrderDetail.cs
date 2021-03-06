
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.entities
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public double Balance { get; set; }
        public int? UserId { get; set; }
        public string ClientIp { get; set; }
        public string DateTrade { get; set; }
        public int Status { get; set; }
        public int ProductId { get; set; }
        [NotMapped]
        public Product Product { get; set; }
    }
}
