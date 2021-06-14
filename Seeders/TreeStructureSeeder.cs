using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TreeStructure.Entities;

namespace TreeStructure
{
    public class TreeStructureSeeder
    {
        private readonly TreeStructureDbContext _dbContext;

        public TreeStructureSeeder(TreeStructureDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Roles.Any())
                {
                    var roles = GetRoles();
                    _dbContext.Roles.AddRange(roles);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Role> GetRoles()
        {
            var roles = new List<Role>()
            {
                new Role()
                {
                    Name = "User"
                },

                new Role()
                {
                    Name = "Admin"
                },
            };

            return roles;
        }
    }
}
