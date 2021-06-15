using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Models.SwaggerExamples.Requests
{
    public class CreateNodeModelExample : IExamplesProvider<CreateNodeDto>
    {
        public CreateNodeDto GetExamples()
        {
            return new CreateNodeDto()
            {
                NodeName = "Kali Linux",
                ParentName = "Debian"
            };
        }
    }
}
