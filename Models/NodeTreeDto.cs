using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Entities;
using TreeStructure.Mappings;

namespace TreeStructure.Models
{
    public class NodeTreeDto : IMap
    {
        public Guid Guid { get; set; }
        public string stringObjectNodeTree { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NodeTree, NodeTreeDto>();
        }
    }
}
