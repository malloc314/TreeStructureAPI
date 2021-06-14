using AutoMapper;
using TreeStructure.Entities;
using TreeStructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using TreeStructure.Repositories;

namespace TreeStructure.Serveces
{
    public class NodeTreeService : INodeTreeService
    {
        private readonly TreeStructureDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly INodeTreeRepository _repository;

        public NodeTreeService(TreeStructureDbContext dbContext, IMapper mapper, INodeTreeRepository repository)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _repository = repository;
        }

        public List<NodeTreeDto> GetNodetrees()
        {
            var trees = _dbContext.NodeTrees.ToList();

            var mappingNodeTree = _mapper.Map<List<NodeTreeDto>>(trees);

            return mappingNodeTree;
        }

        public GetNodeTreeDto GetNodetree(Guid guid)
        {
            var tree = _dbContext.NodeTrees
                .FirstOrDefault(e => e.Guid == guid);

            var json = tree.JsonNodeTree;

            var nodeTree = JsonSerializer
                .Deserialize<GetNodeTreeDto>(json);

            return nodeTree;
        }

        public GetNodeTreeDto GetSortNodetree(Guid guid, string nodeName, string sort)
        {
            var tree = _dbContext.NodeTrees
                .FirstOrDefault(e => e.Guid == guid);

            var json = tree.JsonNodeTree;

            var nodeTree = JsonSerializer
                .Deserialize<NodeTreeMethod>(json);

            nodeTree.CreatePatternAscending(nodeTree, nodeName, sort);

            nodeTree.SortNodes(nodeTree, nodeName, nodeTree.pattern);

            var mapping = _mapper.Map<GetNodeTreeDto>(nodeTree);

            return mapping;


        }

        public void CreateNodeTree(CreateNodeTreeDto dto)
        {
            var jsonSerialize = JsonSerializer.Serialize(dto);

            var mappingNodeTree = new NodeTree()
            {
                JsonNodeTree = jsonSerialize
            };

            _dbContext.Add(mappingNodeTree);
            _dbContext.SaveChanges();
        }

        public bool CreateNode(Guid guid, CreateNodeDto dto)
        {
            var tree = _dbContext.NodeTrees
                .FirstOrDefault(e => e.Guid == guid);

            if (tree is null)
                return false;

            var json = tree.JsonNodeTree;

            var nodeTree = JsonSerializer
                    .Deserialize<NodeTreeMethod>(json);

            //var nodeTree = _repository.DeserializeMet(guid);

            nodeTree.AddNode(nodeTree, dto.ParentName, dto.NodeName);

            json = JsonSerializer.Serialize(nodeTree);

            tree.JsonNodeTree = json;

            _dbContext.SaveChanges();

            return true;
        }

        public bool UpdateNode(Guid guid, UpdateNodeDto dto)
        {
            var tree = _dbContext.NodeTrees
                .FirstOrDefault(e => e.Guid == guid);

            if (tree is null)
                return false;

            var json = tree.JsonNodeTree;

            var nodeTree = JsonSerializer
                    .Deserialize<NodeTreeMethod>(json);

            nodeTree.UpdateNode(nodeTree, dto.OldName, dto.NewName);

            json = JsonSerializer.Serialize(nodeTree);

            tree.JsonNodeTree = json;

            _dbContext.SaveChanges();

            return true;
        }

        public bool RemoveNode(Guid guid, string nodeName)
        {
            var tree = _dbContext.NodeTrees
                .FirstOrDefault(e => e.Guid == guid);

            if (tree is null)
                return false;

            var json = tree.JsonNodeTree;

            var nodeTree = JsonSerializer
                    .Deserialize<NodeTreeMethod>(json);

            nodeTree.RemoveNode(nodeTree, nodeName);

            json = JsonSerializer.Serialize(nodeTree);

            tree.JsonNodeTree = json;

            _dbContext.SaveChanges();

            return true;
        }
    }
}
