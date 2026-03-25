using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class UserTypeAllocationResponseDTO : BaseResponseDTO
    {
        public int UserTypeId { get; set; }
        public int UserInfoId { get; set; }
    }
}
