using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class LearningLevelController : BaseController
    {
        private readonly LearningLevelServices _LearningLevelService;

        public LearningLevelController(LearningLevelServices LearningLevelService)
        {
            _LearningLevelService = LearningLevelService;
        }

        [HttpPost("LearningLevel")]
        public ActionResult Post([FromForm] LearningLevelRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _LearningLevelService.AddLearningLevel(request),
                message = "Created Successfully"
            });
        }

        [HttpGet("LearningLevel")]
        public ActionResult GetAllLearningLevel()
        {
            return new JsonResult(new
            {
                success = true,
                data = _LearningLevelService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] LearningLevelRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _LearningLevelService.RemoveLearningLevel(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
