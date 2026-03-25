using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class BlockController : BaseController
    {
        private readonly BlockServices _blockService;

        public BlockController(BlockServices blockService)
        {
            _blockService = blockService;
        }

        [HttpPost("Block")]
        public async Task<IActionResult> Post([FromForm] BlockRequestDTO request)
        {
            var result = await _blockService.AddBlock(request);
            return new JsonResult(new
            {
                success = true,
                data = result,
                message = "Created Successfully"
            });
        }

        [HttpGet("Block")]
        public IActionResult GetAllBlocks()
        {
            var result = _blockService.GetAll();
            return new JsonResult(new
            {
                success = true,
                data = result,
                message = "Retrieved successfully"
            });
        }

        [HttpPost("DeleteBlock/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _blockService.RemoveBlock(id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Block not found"
            });
        }
    }
}
