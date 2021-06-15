using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TreeStructure.Models.SwaggerExamples.Requests
{
    public class CreateNodeTreeModelExample : IExamplesProvider<CreateNodeTreeDto>
    {
        public CreateNodeTreeDto GetExamples()
        {
            var JsonNodeTree = "{\"Data\":\"Linux\",\"Children\":[{\"Data\":\"Debian\",\"Children\":[{\"Data\":\"Knoppix\",\"Children\":[]},{\"Data\":\"Ubuntu\",\"Children\":[]}]},{\"Data\":\"Gentoo\",\"Children\":[]},{\"Data\":\"Red Hat\",\"Children\":[{\"Data\":\"Fedora Core\",\"Children\":[]},{\"Data\":\"RHEL\",\"Children\":[{\"Data\":\"CentOS\",\"Children\":[]},{\"Data\":\"Oracle Linux\",\"Children\":[]}]}]}]}";

            var nodeTree = JsonSerializer
                .Deserialize<CreateNodeTreeDto>(JsonNodeTree);

            return nodeTree;
        }
    }
}


