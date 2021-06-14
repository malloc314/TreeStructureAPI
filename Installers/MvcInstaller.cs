using TreeStructure.Entities;
using TreeStructure.Serveces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Repositories;

namespace TreeStructure.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TreeStructureDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("TreeStructureCsWin")));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<INodeTreeService, NodeTreeService>();
            services.AddScoped<INodeTreeRepository, NodeTreeRepository>();

            services.AddControllers();
        }
    }
}
