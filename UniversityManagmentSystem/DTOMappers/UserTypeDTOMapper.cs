using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UserTypeDTOMapper
    {
        // Create new entity from request DTO
        public static UserType UserTypeDTOToEntityMapper(UserTypeRequestDTO requestDTO)
        {
            UserType userType = new UserType();
            userType.UserTypeCode = requestDTO.UserTypeCode;
            userType.UserTypeName = requestDTO.UserTypeName;
            return userType;
        }

        // Update existing entity with request DTO
        public static UserType UserTypeDTOToEntityMappers(UserType userType, UserTypeRequestDTO requestDTO)
        {
            userType.UserTypeCode = requestDTO.UserTypeCode;
            userType.UserTypeName = requestDTO.UserTypeName;
            return userType;
        }

        // Map entity to response DTO
        public static UserTypeResponseDTO EntityToUserTypeDTO(UserType userType)
        {
            UserTypeResponseDTO responseDTO = new UserTypeResponseDTO();
            responseDTO.Id = userType.Id;
            responseDTO.UserTypeCode = userType.UserTypeCode;
            responseDTO.UserTypeName = userType.UserTypeName;
            responseDTO.CreatedAt = userType.CreatedAt;
            responseDTO.UpdatedAt = userType.UpdatedAt;
            responseDTO.IsActive = userType.IsActive;
            return responseDTO;
        }

        // Map list of entities to list of response DTOs
        public static List<UserTypeResponseDTO> UserTypeEntityToDTOMapper(List<UserType> userTypes)
        {
            List<UserTypeResponseDTO> userTypeResponseDTOs = new List<UserTypeResponseDTO>();
            foreach (UserType userType in userTypes)
            {
                UserTypeResponseDTO responseDTO = EntityToUserTypeDTO(userType);
                userTypeResponseDTOs.Add(responseDTO);
            }
            return userTypeResponseDTOs;
        }
    }
}
