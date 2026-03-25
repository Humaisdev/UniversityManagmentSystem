using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UserTypeAllocationDTOMapper
    {
        // Create new entity from request DTO
        public static UserTypeAllocation UserTypeAllocationDTOToEntityMapper(UserTypeAllocationRequestDTO requestDTO)
        {
            UserTypeAllocation allocation = new UserTypeAllocation();
            allocation.UserTypeId = requestDTO.UserTypeId;
            allocation.UserInfoId = requestDTO.UserInfoId;
            return allocation;
        }

        // Update existing entity with request DTO
        public static UserTypeAllocation UserTypeAllocationDTOToEntityMappers(UserTypeAllocation allocation, UserTypeAllocationRequestDTO requestDTO)
        {
            allocation.UserTypeId = requestDTO.UserTypeId;
            allocation.UserInfoId = requestDTO.UserInfoId;
            return allocation;
        }

        // Map entity to response DTO
        public static UserTypeAllocationResponseDTO EntityToUserTypeAllocationDTO(UserTypeAllocation allocation)
        {
            UserTypeAllocationResponseDTO responseDTO = new UserTypeAllocationResponseDTO();
            responseDTO.Id = allocation.Id;
            responseDTO.UserTypeId = allocation.UserTypeId;
            responseDTO.UserInfoId = allocation.UserInfoId;
            responseDTO.CreatedAt = allocation.CreatedAt;
            responseDTO.UpdatedAt = allocation.UpdatedAt;
            responseDTO.IsActive = allocation.IsActive;
            return responseDTO;
        }

        // Map list of entities to list of response DTOs
        public static List<UserTypeAllocationResponseDTO> UserTypeAllocationEntityToDTOMapper(List<UserTypeAllocation> allocations)
        {
            List<UserTypeAllocationResponseDTO> responseDTOs = new List<UserTypeAllocationResponseDTO>();
            foreach (UserTypeAllocation allocation in allocations)
            {
                UserTypeAllocationResponseDTO dto = EntityToUserTypeAllocationDTO(allocation);
                responseDTOs.Add(dto);
            }
            return responseDTOs;
        }
    }
}
