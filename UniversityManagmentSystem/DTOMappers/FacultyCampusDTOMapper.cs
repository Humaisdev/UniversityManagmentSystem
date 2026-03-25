using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class FacultyCampusDTOMapper
    {
        public static FacultyCampus FacultyCampusDTOToEntityMapper(FacultyCampusRequestDTO dto)
        {
            FacultyCampus entity = new FacultyCampus();
            entity.FacultyId = dto.FacultyId;
            entity.CampusId = dto.CampusId;
            return entity;
        }

        public static FacultyCampus FacultyCampusEntityToDTOMapper(FacultyCampus entity, FacultyCampusRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.FacultyId = dto.FacultyId;
            entity.CampusId = dto.CampusId;
            return entity;
        }

        public static FacultyCampusResponseDTO EntityToFacultyCampusDTO(FacultyCampus entity)
        {
            FacultyCampusResponseDTO dto = new FacultyCampusResponseDTO();
            dto.Id = entity.Id;
            dto.FacultyId = entity.FacultyId;
            dto.CampusId = entity.CampusId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<FacultyCampusResponseDTO> FacultyCampusEntityToDTOMapper(List<FacultyCampus> entities)
        {
            List<FacultyCampusResponseDTO> dtos = new List<FacultyCampusResponseDTO>();
            foreach (FacultyCampus entity in entities)
            {
                dtos.Add(EntityToFacultyCampusDTO(entity));
            }
            return dtos;
        }
    }
}
