using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class PEODTOMapper
    {
        public static PEO PEODTOToEntityMapper(PEORequestDTO dto)
        {
            PEO entity = new PEO();
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.DegreeProgram = dto.DegreeProgram;
            return entity;
        }

        public static PEO PEOEntityToDTOMapper(PEO entity, PEORequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.DegreeProgram = dto.DegreeProgram;
            return entity;
        }

        public static PEOResponseDTO EntityToPEODTO(PEO entity)
        {
            PEOResponseDTO dto = new PEOResponseDTO();
            dto.Id = entity.Id;
            dto.Description = entity.Description;
            dto.Code = entity.Code;
            dto.DegreeProgram = entity.DegreeProgram;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<PEOResponseDTO> PEOEntityToDTOMapper(List<PEO> entities)
        {
            List<PEOResponseDTO> dtos = new List<PEOResponseDTO>();
            foreach (PEO entity in entities)
            {
                dtos.Add(EntityToPEODTO(entity));
            }
            return dtos;
        }
    }
}
