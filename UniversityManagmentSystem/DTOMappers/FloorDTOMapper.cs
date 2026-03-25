using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class FloorDTOMapper
    {
        public static Floor FloorDTOToEntityMapper(FloorRequestDTO dto)
        {
            Floor entity = new Floor();
            entity.Name = dto.Name;
            entity.Code = dto.Code;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Address = dto.Address;
            entity.BuildingId = dto.BuildingId;
            return entity;
        }

        public static Floor FloorEntityToDTOMapper(Floor entity, FloorRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.Code = dto.Code;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Address = dto.Address;
            entity.BuildingId = dto.BuildingId;
            return entity;
        }

        public static FloorResponseDTO EntityToFloorDTO(Floor entity)
        {
            FloorResponseDTO dto = new FloorResponseDTO();
            dto.Id = entity.Id;
            dto.Name = entity.Name;
            dto.Code = entity.Code;
            dto.Description = entity.Description;
            dto.EstablishedIn = entity.EstablishedIn;
            dto.Address = entity.Address;
            dto.BuildingId = entity.BuildingId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<FloorResponseDTO> FloorEntityToDTOMapper(List<Floor> entities)
        {
            List<FloorResponseDTO> dtos = new List<FloorResponseDTO>();
            foreach (Floor entity in entities)
            {
                dtos.Add(EntityToFloorDTO(entity));
            }
            return dtos;
        }
    }
}
