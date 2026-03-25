using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class FacultyController : BaseController
    {
        private readonly FacultyServices _FacultyService;

        public FacultyController(FacultyServices FacultyService)
        {
            _FacultyService = FacultyService;
        }

        [HttpPost("Faculty")]
        public ActionResult Post([FromForm] FacultyRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _FacultyService.AddFaculty(request), message = "Created Successfully" });
        }
        [HttpGet("Faculty")]
        public ActionResult  GetAllFaculty()
        {
            return new JsonResult(new
            {
                success = true,
                data = _FacultyService.GetAll(),
                message = "Retrieved successfully"
            });
        }
        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] FacultyRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _FacultyService.RemoveFaculty(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}