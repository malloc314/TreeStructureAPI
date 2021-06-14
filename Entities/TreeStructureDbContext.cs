using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Entities
{
    public class TreeStructureDbContext : DbContext
    {
        public TreeStructureDbContext(DbContextOptions options) : base(options) { }

        public DbSet<NodeTree> NodeTrees { get; set; }
    }
}
