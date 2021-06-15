using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Models.SwaggerExamples.Requests
{
    public class UpdateNodeModelExample : IExamplesProvider<UpdateNodeDto>
    {
        public UpdateNodeDto GetExamples()
        {
            return new UpdateNodeDto()
            {
                OldName = "Debian",
                NewName = "Debian <3"
            };
        }
    }
}
