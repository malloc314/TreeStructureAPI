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
using Microsoft.AspNetCore.Identity;
using FluentValidation.AspNetCore;
using TreeStructure.Models;
using FluentValidation;
using TreeStructure.Models.Validators;

namespace TreeStructure.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers().AddFluentValidation();

            services.AddScoped<INodeTreeService, NodeTreeService>();
            
            services.AddScoped<IAccountService, AccountService>();

            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

            services.AddScoped<INodeTreeRepository, NodeTreeRepository>();

            services.AddScoped<IValidator<RegisterUserDto>, RegisterUserDtoValidator>();
        }
    }
}
