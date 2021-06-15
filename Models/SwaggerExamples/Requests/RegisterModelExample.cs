using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Models.SwaggerExamples
{
    public class RegisterModelExample : IExamplesProvider<RegisterUserDto>
    {
        public RegisterUserDto GetExamples()
        {
            return new RegisterUserDto()
            {
                Email = "admin@example.com",
                FirstName = "Adam",
                LastName = "Whale",
                DateOfBirth = DateTime.Now,
                Password = "Admin123",
                ConfirmPassword = "Admin123",
                RoleId = 2
            };
        }
    }
}
