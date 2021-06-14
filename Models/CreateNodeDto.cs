using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Mappings;

namespace TreeStructure.Models
{
    public class CreateNodeDto
    {
        public string ParentName { get; set; }
        public string NodeName { get; set; }
    }
}
