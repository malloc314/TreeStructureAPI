using TreeStructure.Entities;
using TreeStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Serveces
{
    public interface INodeTreeService
    {
        public List<NodeTreeDto> GetNodetrees();
        public GetNodeTreeDto GetNodetree(Guid guid);
        public GetNodeTreeDto GetSortNodetree(Guid guid, string nodeName, string sort);
        public void CreateNodeTree(CreateNodeTreeDto dto);
        public bool CreateNode(Guid guid, CreateNodeDto dto);
        public bool UpdateNode(Guid guid, UpdateNodeDto dto);
        public bool RemoveNode(Guid guid, string nodeName);
    }
}
