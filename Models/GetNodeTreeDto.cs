using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Mappings;

namespace TreeStructure.Models
{
    public class GetNodeTreeDto : IMap
    {
        public string Data { get; set; }
        public List<GetNodeTreeDto> Children { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NodeTreeMethod, GetNodeTreeDto>();
        }
    }
}
