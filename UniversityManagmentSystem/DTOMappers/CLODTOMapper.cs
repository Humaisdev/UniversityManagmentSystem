using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class CLODTOMapper
    {
        public static CLO CLODTOToEntityMapper(CLORequestDTO dto)
        {
            CLO clo = new CLO();
            clo.Description = dto.Description;
            clo.Code = dto.Code;
            clo.LearningTypeId = dto.LearningTypeId;
            clo.LearningLevelId = dto.LearningLevelId;
            return clo;
        }

        public static CLO CLOEntityToDTOMapper(CLO clo, CLORequestDTO dto)
        {
            clo.Id = dto.Id;
            clo.Description = dto.Description;
            clo.Code = dto.Code;
            clo.LearningTypeId = dto.LearningTypeId;
            clo.LearningLevelId = dto.LearningLevelId;
            return clo;
        }

        public static CLOResponseDTO EntityToCLODTO(CLO clo)
        {
            CLOResponseDTO dto = new CLOResponseDTO();
            dto.Id = clo.Id;
            dto.Description = clo.Description;
            dto.Code = clo.Code;
            dto.LearningTypeId = clo.LearningTypeId;
            dto.LearningLevelId = clo.LearningLevelId;
            dto.CreatedAt = clo.CreatedAt;
            dto.UpdatedAt = clo.UpdatedAt;
            dto.GlobalId = clo.GlobalId;
            return dto;
        }

        public static List<CLOResponseDTO> CLOEntityToDTOMapper(List<CLO> clos)
        {
            List<CLOResponseDTO> dtos = new List<CLOResponseDTO>();
            foreach (CLO clo in clos)
            {
                dtos.Add(EntityToCLODTO(clo));
            }
            return dtos;
        }
    }
}
