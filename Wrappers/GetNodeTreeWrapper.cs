using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Models;

namespace TreeStructure.Wrappers
{
    public class GetNodeTreeWrapper
    {
        public Guid Guid { get; set; }
        public GetNodeTreeDto NodeTree { get; set; }
    }
}
