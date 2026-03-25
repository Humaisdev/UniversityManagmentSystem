using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class BuildingController : BaseController
    {
        private readonly BuildingServices _buildingService;

        public BuildingController(BuildingServices buildingService)
        {
            _buildingService = buildingService;
        }

        [HttpPost("Building")]
        public async Task<IActionResult> Post([FromForm] BuildingRequestDTO request)
        {
            var result = await _buildingService.AddBuilding(request);
            return new JsonResult(new
            {
                success = true,
                data = result,
                message = "Created successfully"
            });
        }

        [HttpGet("Building")]
        public IActionResult GetAllBuildings()
        {
            var result = _buildingService.GetAll();
            return new JsonResult(new
            {
                success = true,
                data = result,
                message = "Retrieved successfully"
            });
        }

        [HttpPost("DeleteBuilding/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _buildingService.RemoveBuilding(id);
            return new JsonResult(new
            {
                success = result,
                message = result ? "Deleted successfully" : "Building not found"
            });
        }
    }
}
