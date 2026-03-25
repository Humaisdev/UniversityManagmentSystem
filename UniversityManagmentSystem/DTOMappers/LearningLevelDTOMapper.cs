using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class LearningLevelDTOMapper
    {
        public static LearningLevel LearningLevelDTOToEntityMapper(LearningLevelRequestDTO dto)
        {
            LearningLevel entity = new LearningLevel();
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            return entity;
        }

        public static LearningLevel LearningLevelEntityToDTOMapper(LearningLevel entity, LearningLevelRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            return entity;
        }

        public static LearningLevelResponseDTO EntityToLearningLevelDTO(LearningLevel entity)
        {
            LearningLevelResponseDTO dto = new LearningLevelResponseDTO();
            dto.Id = entity.Id;
            dto.Description = entity.Description;
            dto.Code = entity.Code;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<LearningLevelResponseDTO> LearningLevelEntityToDTOMapper(List<LearningLevel> entities)
        {
            List<LearningLevelResponseDTO> dtos = new List<LearningLevelResponseDTO>();
            foreach (LearningLevel entity in entities)
            {
                dtos.Add(EntityToLearningLevelDTO(entity));
            }
            return dtos;
        }
    }
}
