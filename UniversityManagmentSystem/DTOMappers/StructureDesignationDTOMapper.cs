using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class StructureDesignationDTOMapper
    {
        public static StructureDesignation StructureDesignationDTOToEntityMapper(StructureDesignationRequestDTO dto)
        {
            StructureDesignation entity = new StructureDesignation();
            entity.StructureUnitId = dto.StructureUnitId;
            entity.DesignationId = dto.DesignationId;
            return entity;
        }

        public static StructureDesignation StructureDesignationEntityToDTOMapper(StructureDesignation entity, StructureDesignationRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.StructureUnitId = dto.StructureUnitId;
            entity.DesignationId = dto.DesignationId;
            return entity;
        }

        public static StructureDesignationResponseDTO EntityToStructureDesignationDTO(StructureDesignation entity)
        {
            StructureDesignationResponseDTO dto = new StructureDesignationResponseDTO();
            dto.Id = entity.Id;
            dto.StructureUnitId = entity.StructureUnitId;
            dto.DesignationId = entity.DesignationId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<StructureDesignationResponseDTO> StructureDesignationEntityToDTOMapper(List<StructureDesignation> entities)
        {
            List<StructureDesignationResponseDTO> dtos = new List<StructureDesignationResponseDTO>();
            foreach (StructureDesignation entity in entities)
            {
                dtos.Add(EntityToStructureDesignationDTO(entity));
            }
            return dtos;
        }
    }
}
