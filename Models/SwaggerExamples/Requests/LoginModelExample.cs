using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Models.SwaggerExamples.Requests
{
    public class LoginModelExample : IExamplesProvider<LoginDto>
    {
        public LoginDto GetExamples()
        {
            return new LoginDto()
            {
                Email = "admin@example.com",
                Password = "Admin123"
            };
        }
    }
}
