using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UserRightDTOMapper
    {
        public static UserRight UserRightDTOToEntityMapper(UserRightRequestDTO dto)
        {
            UserRight entity = new UserRight();
            entity.UserRightCode = dto.UserRightCode;
            entity.UserRightName = dto.UserRightName;
            entity.URL = dto.URL;
            entity.TabName = dto.TabName;
            return entity;
        }

        public static UserRight UserRightEntityToDTOMapper(UserRight entity, UserRightRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.UserRightCode = dto.UserRightCode;
            entity.UserRightName = dto.UserRightName;
            entity.URL = dto.URL;
            entity.TabName = dto.TabName;
            return entity;
        }

        public static UserRightResponseDTO EntityToUserRightDTO(UserRight entity)
        {
            UserRightResponseDTO dto = new UserRightResponseDTO();
            dto.Id = entity.Id;
            dto.UserRightCode = entity.UserRightCode;
            dto.UserRightName = entity.UserRightName;
            dto.URL = entity.URL;
            dto.TabName = entity.TabName;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<UserRightResponseDTO> UserRightEntityToDTOMapper(List<UserRight> entities)
        {
            List<UserRightResponseDTO> dtos = new List<UserRightResponseDTO>();
            foreach (UserRight entity in entities)
            {
                dtos.Add(EntityToUserRightDTO(entity));
            }
            return dtos;
        }
    }
}
