using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class InstituteDTOMapper
    {
        public static Institute InstituteDTOToEntityMapper(InstituteRequestDTO dto)
        {
            Institute entity = new Institute();
            entity.InstituteName = dto.InstituteName;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Code = dto.Code;
            entity.FacultyCampusId = dto.FacultyCampusId;
            return entity;
        }

        public static Institute InstituteEntityToDTOMapper(Institute entity, InstituteRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.InstituteName = dto.InstituteName;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Code = dto.Code;
            entity.FacultyCampusId = dto.FacultyCampusId;
            return entity;
        }

        public static InstituteResponseDTO EntityToInstituteDTO(Institute entity)
        {
            InstituteResponseDTO dto = new InstituteResponseDTO();
            dto.Id = entity.Id;
            dto.InstituteName = entity.InstituteName;
            dto.Description = entity.Description;
            dto.EstablishedIn = entity.EstablishedIn;
            dto.Code = entity.Code;
            dto.FacultyCampusId = entity.FacultyCampusId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<InstituteResponseDTO> InstituteEntityToDTOMapper(List<Institute> entities)
        {
            List<InstituteResponseDTO> dtos = new List<InstituteResponseDTO>();
            foreach (Institute entity in entities)
            {
                dtos.Add(EntityToInstituteDTO(entity));
            }
            return dtos;
        }
    }
}
