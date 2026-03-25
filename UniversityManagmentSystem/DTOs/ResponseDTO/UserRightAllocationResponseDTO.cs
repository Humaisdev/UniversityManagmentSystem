using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class UserRightAllocationResponseDTO : BaseResponseDTO
    {
        public int UserRightId { get; set; }
        public int UserTypeId { get; set; }
    }
}
