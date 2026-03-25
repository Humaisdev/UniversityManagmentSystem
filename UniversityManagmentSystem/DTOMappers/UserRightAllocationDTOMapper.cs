using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UserRightAllocationDTOMapper
    {
        public static UserRightAllocation UserRightAllocationDTOToEntityMapper(UserRightAllocationRequestDTO dto)
        {
            UserRightAllocation entity = new UserRightAllocation();
            entity.UserRightId = dto.UserRightId;
            entity.UserTypeId = dto.UserTypeId;
            return entity;
        }

        public static UserRightAllocation UserRightAllocationEntityToDTOMapper(UserRightAllocation entity, UserRightAllocationRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.UserRightId = dto.UserRightId;
            entity.UserTypeId = dto.UserTypeId;
            return entity;
        }

        public static UserRightAllocationResponseDTO EntityToUserRightAllocationDTO(UserRightAllocation entity)
        {
            UserRightAllocationResponseDTO dto = new UserRightAllocationResponseDTO();
            dto.Id = entity.Id;
            dto.UserRightId = entity.UserRightId;
            dto.UserTypeId = entity.UserTypeId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<UserRightAllocationResponseDTO> UserRightAllocationEntityToDTOMapper(List<UserRightAllocation> entities)
        {
            List<UserRightAllocationResponseDTO> dtos = new List<UserRightAllocationResponseDTO>();
            foreach (UserRightAllocation entity in entities)
            {
                dtos.Add(EntityToUserRightAllocationDTO(entity));
            }
            return dtos;
        }
    }
}
