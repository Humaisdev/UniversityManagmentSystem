using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class CampusDTOMapper
    {
        public static Campus CampusDTOToEntityMapper(CampusRequestDTO dto)
        {
            Campus campus = new Campus();
            campus.Name = dto.Name;
            campus.Code = dto.Code;
            campus.Description = dto.Description;
            campus.EstablishedIn = dto.EstablishedIn;
            campus.Address = dto.Address;
            campus.UniversityId = dto.UniversityId;
            return campus;
        }

        public static Campus CampusEntityToDTOMapper(Campus campus, CampusRequestDTO dto)
        {
            campus.Id = dto.Id;
            campus.Name = dto.Name;
            campus.Code = dto.Code;
            campus.Description = dto.Description;
            campus.EstablishedIn = dto.EstablishedIn;
            campus.Address = dto.Address;
            campus.UniversityId = dto.UniversityId;
            return campus;
        }

        public static CampusResponseDTO EntityToCampusDTO(Campus campus)
        {
            CampusResponseDTO dto = new CampusResponseDTO();
            dto.Id = campus.Id;
            dto.Name = campus.Name;
            dto.Code = campus.Code;
            dto.Description = campus.Description;
            dto.EstablishedIn = campus.EstablishedIn;
            dto.Address = campus.Address;
            dto.UniversityId = campus.UniversityId;
            dto.CreatedAt = campus.CreatedAt;
            dto.UpdatedAt = campus.UpdatedAt;
            dto.GlobalId = campus.GlobalId;
            return dto;
        }

        public static List<CampusResponseDTO> CampusEntityToDTOMapper(List<Campus> campuses)
        {
            List<CampusResponseDTO> dtos = new List<CampusResponseDTO>();
            foreach (Campus campus in campuses)
            {
                dtos.Add(EntityToCampusDTO(campus));
            }
            return dtos;
        }
    }
}
