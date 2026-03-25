using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class PLODTOMapper
    {
        public static PLO PLODTOToEntityMapper(PLORequestDTO dto)
        {
            PLO entity = new PLO();
            entity.Description = dto.Description;
            entity.code = dto.Code;
            entity.DegreeProgramId = dto.DegreeProgramId;
            return entity;
        }

        public static PLO PLOEntityToDTOMapper(PLO entity, PLORequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.Description = dto.Description;
            entity.code = dto.Code;
            entity.DegreeProgramId = dto.DegreeProgramId;
            return entity;
        }

        public static PLOResponseDTO EntityToPLODTO(PLO entity)
        {
            PLOResponseDTO dto = new PLOResponseDTO();
            dto.Id = entity.Id;
            dto.Description = entity.Description;
            dto.Code = entity.code;
            dto.DegreeProgramId = entity.DegreeProgramId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<PLOResponseDTO> PLOEntityToDTOMapper(List<PLO> entities)
        {
            List<PLOResponseDTO> dtos = new List<PLOResponseDTO>();
            foreach (PLO entity in entities)
            {
                dtos.Add(EntityToPLODTO(entity));
            }
            return dtos;
        }
    }
}
