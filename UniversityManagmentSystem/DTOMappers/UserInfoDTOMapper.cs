using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UserInfoDTOMapper
    {
        public static UserInfo UserInfoDTOToEntityMapper(UserInfoRequestDTO dto)  
        {
            UserInfo entity = new UserInfo();
            entity.UserName = dto.UserName;
            entity.UiUser = dto.UiUser;
            entity.UiPassword = dto.UiPassword;
            return entity;
        }

        public static UserInfo UserInfoEntityToDTOMapper(UserInfo entity, UserInfoRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.UserName = dto.UserName;
            entity.UiUser = dto.UiUser;
            entity.UiPassword = dto.UiPassword;
            return entity;
        }

        public static UserInfoResponseDTO EntityToUserInfoDTO(UserInfo entity)
        {
            UserInfoResponseDTO dto = new UserInfoResponseDTO();
            dto.Id = entity.Id;
            dto.UserName = entity.UserName;
            dto.UiUser = entity.UiUser;
            dto.UiPassword = entity.UiPassword;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<UserInfoResponseDTO> UserInfoEntityToDTOMapper(List<UserInfo> entities)
        {
            List<UserInfoResponseDTO> dtos = new List<UserInfoResponseDTO>();
            foreach (UserInfo entity in entities)
            {
                dtos.Add(EntityToUserInfoDTO(entity));
            }
            return dtos;
        }
    }
}
