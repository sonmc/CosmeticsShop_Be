using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public int CategoryId { get; set; }
   
        public string NameProduct { get; set; }
        public string Images { get; set; }
        public double? ListedPrice { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public int Evaluate { get; set; }
        public string IdCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long TotalItems { get; set; }
        public bool IsDisabled { get; set; }
        public List<Composition> Compositions { get; set; }
        [NotMapped]
        public string NameCategory { get; set; }
    }
}
