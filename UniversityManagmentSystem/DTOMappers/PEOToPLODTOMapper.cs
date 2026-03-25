using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class PEOToPLODTOMapper
    {
        public static PEOToPLO PEOToPLODTOToEntityMapper(PEOToPLORequestDTO dto)
        {
            PEOToPLO entity = new PEOToPLO();
            entity.Weightage = dto.Weightage;
            entity.PEOId = dto.PEOId;
            entity.PLOId = dto.PLOId;
            return entity;
        }

        public static PEOToPLO PEOToPLOEntityToDTOMapper(PEOToPLO entity, PEOToPLORequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.Weightage = dto.Weightage;
            entity.PEOId = dto.PEOId;
            entity.PLOId = dto.PLOId;
            return entity;
        }

        public static PEOToPLOResponseDTO EntityToPEOToPLODTO(PEOToPLO entity)
        {
            PEOToPLOResponseDTO dto = new PEOToPLOResponseDTO();
            dto.Id = entity.Id;
            dto.Weightage = entity.Weightage;
            dto.PEOId = entity.PEOId;
            dto.PLOId = entity.PLOId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<PEOToPLOResponseDTO> PEOToPLOEntityToDTOMapper(List<PEOToPLO> entities)
        {
            List<PEOToPLOResponseDTO> dtos = new List<PEOToPLOResponseDTO>();
            foreach (PEOToPLO entity in entities)
            {
                dtos.Add(EntityToPEOToPLODTO(entity));
            }
            return dtos;
        }
    }
}
