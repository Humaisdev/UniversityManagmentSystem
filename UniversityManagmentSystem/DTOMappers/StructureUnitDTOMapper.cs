using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class StructureUnitDTOMapper
    {
        public static StructureUnit StructureUnitDTOToEntityMapper(StructureUnitRequestDTO dto)
        {
            StructureUnit entity = new StructureUnit();
            entity.StructureUnitName = dto.StructureUnitName;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.StructureTypeId = dto.StructureTypeId;
            return entity;
        }

        public static StructureUnit StructureUnitEntityToDTOMapper(StructureUnit entity, StructureUnitRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.StructureUnitName = dto.StructureUnitName;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.StructureTypeId = dto.StructureTypeId;
            return entity;
        }

        public static StructureUnitResponseDTO EntityToStructureUnitDTO(StructureUnit entity)
        {
            StructureUnitResponseDTO dto = new StructureUnitResponseDTO();
            dto.Id = entity.Id;
            dto.StructureUnitName = entity.StructureUnitName;
            dto.Description = entity.Description;
            dto.Code = entity.Code;
            dto.StructureTypeId = entity.StructureTypeId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<StructureUnitResponseDTO> StructureUnitEntityToDTOMapper(List<StructureUnit> entities)
        {
            List<StructureUnitResponseDTO> dtos = new List<StructureUnitResponseDTO>();
            foreach (StructureUnit entity in entities)
            {
                dtos.Add(EntityToStructureUnitDTO(entity));
            }
            return dtos;
        }
    }
}
