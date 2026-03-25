using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class CourseSchemeDTOMapper
    {
        public static CourseScheme CourseSchemeDTOToEntityMapper(CourseSchemeRequestDTO dto)
        {
            CourseScheme entity = new CourseScheme();
            entity.SubjectId = dto.SubjectId;
            entity.SubjectTypeId = dto.SubjectTypeId;
            entity.CreditHours = dto.CreditHours;
            entity.DegreeProgramId = dto.DegreeProgramId;
            entity.ProgramSessionId = dto.ProgramSessionId;
            entity.SemesterId = dto.SemesterId;
            return entity;
        }

        public static CourseScheme CourseSchemeEntityToDTOMapper(CourseScheme entity, CourseSchemeRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.SubjectId = dto.SubjectId;
            entity.SubjectTypeId = dto.SubjectTypeId;
            entity.CreditHours = dto.CreditHours;
            entity.DegreeProgramId = dto.DegreeProgramId;
            entity.ProgramSessionId = dto.ProgramSessionId;
            entity.SemesterId = dto.SemesterId;
            return entity;
        }

        public static CourseSchemeResponseDTO EntityToCourseSchemeDTO(CourseScheme entity)
        {
            CourseSchemeResponseDTO dto = new CourseSchemeResponseDTO();
            dto.Id = entity.Id;
            dto.SubjectId = entity.SubjectId;
            dto.SubjectTypeId = entity.SubjectTypeId;
            dto.CreditHours = entity.CreditHours;
            dto.DegreeProgramId = entity.DegreeProgramId;
            dto.ProgramSessionId = entity.ProgramSessionId;
            dto.SemesterId = entity.SemesterId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<CourseSchemeResponseDTO> CourseSchemeEntityToDTOMapper(List<CourseScheme> entities)
        {
            List<CourseSchemeResponseDTO> dtos = new List<CourseSchemeResponseDTO>();
            foreach (CourseScheme entity in entities)
            {
                dtos.Add(EntityToCourseSchemeDTO(entity));
            }
            return dtos;
        }
    }
}