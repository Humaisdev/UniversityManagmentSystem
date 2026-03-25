using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class UserInfoResponseDTO : BaseResponseDTO
    {
        public string UserName { get; set; }
        public string UiUser { get; set; }
        // For security, generally you wouldn't expose passwords in responses
        public string UiPassword { get; set; }
    }
}
