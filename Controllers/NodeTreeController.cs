using AutoMapper;
using TreeStructure.Entities;
using TreeStructure.Models;
using TreeStructure.Serveces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Wrappers;
using Microsoft.AspNetCore.Authorization;

namespace TreeStructure.Controllers
{
    [Route("api/nodetree")]
    [ApiController]
    [Authorize]
    public class NodeTreeController : ControllerBase
    {
        private readonly INodeTreeService _service;

        public NodeTreeController(INodeTreeService service)
        {
            _service = service;
        }

        [HttpGet("get")]
        [Authorize(Roles = "User, Admin")]
        public ActionResult GetNodeTrees()
        {
            var trees = _service.GetNodetrees();

            return Ok(trees);
        }

        [HttpGet("get/{guid}")]
        [Authorize(Roles = "User, Admin")]
        public ActionResult GetNodeTree([FromRoute] Guid guid)
        {
            var tree = _service.GetNodetree(guid);

            return Ok(new GetNodeTreeWrapper()
            {
                Guid = guid,
                NodeTree = tree
            });
        }

        [HttpGet("sort/{guid}/{node}/{sort}")]
        [Authorize(Roles = "User, Admin")]
        public ActionResult GetSortNodeTree([FromRoute] Guid guid, string node, string sort)
        {
            var tree = _service.GetSortNodetree(guid, node, sort);

            return Ok(new GetNodeTreeWrapper()
            {
                Guid = guid,
                NodeTree = tree
            });
        }

        [HttpPost("create")]
        [Authorize(Roles = "User, Admin")]
        public ActionResult CreateNodeTree([FromBody] CreateNodeTreeDto dto)
        {
            _service.CreateNodeTree(dto);

            return Created("Created", null);
        }

        [HttpPut("create/{guid}")]
        [Authorize(Roles = "User, Admin")]
        public ActionResult CreateNode([FromRoute] Guid guid, [FromBody] CreateNodeDto dto)
        {
            var isCreated = _service.CreateNode(guid, dto);

            if (!isCreated)
                return NotFound();

            return Ok($"Node {dto.NodeName} was created: {isCreated}");
        }

        [HttpPut("update/{guid}")]
        [Authorize(Roles = "User, Admin")]
        public ActionResult UpdateNode([FromRoute] Guid guid, [FromBody] UpdateNodeDto dto)
        {
            var isUpdated = _service.UpdateNode(guid, dto);

            if (!isUpdated)
                return NotFound();

            return Ok($"Node {dto.OldName} was updated to {dto.NewName}");
        }

        [HttpDelete("delete/{guid}/{node}")]
        [Authorize(Roles = "User, Admin")]
        public ActionResult Delete([FromRoute] Guid guid, [FromRoute] string node)
        {
            var isDeleted = _service.RemoveNode(guid, node);

            if (!isDeleted)
                return NotFound();

            return NoContent();
        }
    }
}
