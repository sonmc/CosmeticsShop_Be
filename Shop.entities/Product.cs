using System; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace Shop.entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IdCategory { get; set; }
        public string NameCategory { get; set; }
        public string NameProduct { get; set; }
        public string Images { get; set; }
        public double? ListedPrice { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public int Evaluate { get; set; }
        public int Views { get; set; }
        public string IdCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string MetaTitle { get; set; }
        public long? Status { get; set; }
        public long TotalItems { get; set; } 
        public virtual OrderDetail OrderDetail { get; set; }
    }
}
