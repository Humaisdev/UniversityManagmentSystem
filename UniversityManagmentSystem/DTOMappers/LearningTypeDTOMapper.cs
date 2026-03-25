using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class LearningTypeDTOMapper
    {
        public static LearningType LearningTypeDTOToEntityMapper(LearningTypeRequestDTO dto)
        {
            LearningType entity = new LearningType();
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            return entity;
        }

        public static LearningType LearningTypeEntityToDTOMapper(LearningType entity, LearningTypeRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            return entity;
        }

        public static LearningTypeResponseDTO EntityToLearningTypeDTO(LearningType entity)
        {
            LearningTypeResponseDTO dto = new LearningTypeResponseDTO();
            dto.Id = entity.Id;
            dto.Description = entity.Description;
            dto.Code = entity.Code;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<LearningTypeResponseDTO> LearningTypeEntityToDTOMapper(List<LearningType> entities)
        {
            List<LearningTypeResponseDTO> dtos = new List<LearningTypeResponseDTO>();
            foreach (LearningType entity in entities)
            {
                dtos.Add(EntityToLearningTypeDTO(entity));
            }
            return dtos;
        }
    }
}
