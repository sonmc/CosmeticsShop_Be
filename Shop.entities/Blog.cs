
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace Shop.entities
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
