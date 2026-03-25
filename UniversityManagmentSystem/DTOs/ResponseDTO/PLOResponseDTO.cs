using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class PLOResponseDTO : BaseResponseDTO
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeProgramId { get; set; }
    }
}
