using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class DegreeProgramDTOMapper
    {
        public static DegreeProgram DegreeProgramDTOToEntityMapper(DegreeProgramRequestDTO dto)
        {
            DegreeProgram entity = new DegreeProgram();
            entity.DegreeProgramName = dto.DegreeProgramName;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.DegreeLevelId = dto.DegreeLevelId;
            entity.DepartmentId = dto.DepartmentId;
            return entity;
        }

        public static DegreeProgram DegreeProgramEntityToDTOMapper(DegreeProgram entity, DegreeProgramRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.DegreeProgramName = dto.DegreeProgramName;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.DegreeLevelId = dto.DegreeLevelId;
            entity.DepartmentId = dto.DepartmentId;
            return entity;
        }

        public static DegreeProgramResponseDTO EntityToDegreeProgramDTO(DegreeProgram entity)
        {
            DegreeProgramResponseDTO dto = new DegreeProgramResponseDTO();
            dto.Id = entity.Id;
            dto.DegreeProgramName = entity.DegreeProgramName;
            dto.Description = entity.Description;
            dto.Code = entity.Code;
            dto.DegreeLevelId = entity.DegreeLevelId;
            dto.DepartmentId = entity.DepartmentId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<DegreeProgramResponseDTO> DegreeProgramEntityToDTOMapper(List<DegreeProgram> entities)
        {
            List<DegreeProgramResponseDTO> dtos = new List<DegreeProgramResponseDTO>();
            foreach (DegreeProgram entity in entities)
            {
                dtos.Add(EntityToDegreeProgramDTO(entity));
            }
            return dtos;
        }
    }
}
