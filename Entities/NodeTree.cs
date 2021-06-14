using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Models;

namespace TreeStructure.Entities
{
    [Table("NodeTrees")]
    public class NodeTree
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }
        
        [Required]
        public string JsonNodeTree { get; set; }
    }
}