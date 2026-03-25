using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class PLOToCLODTOMapper
    {
        public static PLOToCLO PLOToCLODTOToEntityMapper(PLOToCLORequestDTO dto)
        {
            PLOToCLO entity = new PLOToCLO();
            entity.PLOId = dto.PLOId;
            entity.CLOId = dto.CLOId;
            return entity;
        }

        public static PLOToCLO PLOToCLOEntityToDTOMapper(PLOToCLO entity, PLOToCLORequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.PLOId = dto.PLOId;
            entity.CLOId = dto.CLOId;
            return entity;
        }

        public static PLOToCLOResponseDTO EntityToPLOToCLODTO(PLOToCLO entity)
        {
            PLOToCLOResponseDTO dto = new PLOToCLOResponseDTO();
            dto.Id = entity.Id;
            dto.PLOId = entity.PLOId;
            dto.CLOId = entity.CLOId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<PLOToCLOResponseDTO> PLOToCLOEntityToDTOMapper(List<PLOToCLO> entities)
        {
            List<PLOToCLOResponseDTO> dtos = new List<PLOToCLOResponseDTO>();
            foreach (PLOToCLO entity in entities)
            {
                dtos.Add(EntityToPLOToCLODTO(entity));
            }
            return dtos;
        }
    }
}
