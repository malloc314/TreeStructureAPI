using AutoMapper;
using TreeStructure.Entities;
using TreeStructure.Mappings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Models
{
    public class CreateNodeTreeDto : IMap
    {
        public string Data { get; set; }

        public List<CreateNodeTreeDto> Children { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateNodeTreeDto, NodeTreeMethod>();
        }
    }
}
