using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class DepartmentDTOMapper
    {
        public static Department DepartmentDTOToEntityMapper(DepartmentRequestDTO dto)
        {
            Department entity = new Department();
            entity.DepartmentName = dto.DepartmentName;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Code = dto.Code;
            entity.InstituteId = dto.InstituteId;
            return entity;
        }

        public static Department DepartmentEntityToDTOMapper(Department entity, DepartmentRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.DepartmentName = dto.DepartmentName;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Code = dto.Code;
            entity.InstituteId = dto.InstituteId;
            return entity;
        }

        public static DepartmentResponseDTO EntityToDepartmentDTO(Department entity)
        {
            DepartmentResponseDTO dto = new DepartmentResponseDTO();
            dto.Id = entity.Id;
            dto.DepartmentName = entity.DepartmentName;
            dto.Description = entity.Description;
            dto.EstablishedIn = entity.EstablishedIn;
            dto.Code = entity.Code;
            dto.InstituteId = entity.InstituteId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<DepartmentResponseDTO> DepartmentEntityToDTOMapper(List<Department> entities)
        {
            List<DepartmentResponseDTO> dtos = new List<DepartmentResponseDTO>();
            foreach (Department entity in entities)
            {
                dtos.Add(EntityToDepartmentDTO(entity));
            }
            return dtos;
        }
    }
}
