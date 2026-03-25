using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class RoomDTOMapper
    {
        public static Room RoomDTOToEntityMapper(RoomRequestDTO dto)
        {
            Room entity = new Room();
            entity.Name = dto.Name;
            entity.Code = dto.Code;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Address = dto.Address;
            entity.FloorId = dto.FloorId;
            return entity;
        }

        public static Room RoomEntityToDTOMapper(Room entity, RoomRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.Code = dto.Code;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Address = dto.Address;
            entity.FloorId = dto.FloorId;
            return entity;
        }

        public static RoomResponseDTO EntityToRoomDTO(Room entity)
        {
            RoomResponseDTO dto = new RoomResponseDTO();
            dto.Id = entity.Id;
            dto.Name = entity.Name;
            dto.Code = entity.Code;
            dto.Description = entity.Description;
            dto.EstablishedIn = entity.EstablishedIn;
            dto.Address = entity.Address;
            dto.FloorId = entity.FloorId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<RoomResponseDTO> RoomEntityToDTOMapper(List<Room> entities)
        {
            List<RoomResponseDTO> dtos = new List<RoomResponseDTO>();
            foreach (Room entity in entities)
            {
                dtos.Add(EntityToRoomDTO(entity));
            }
            return dtos;
        }
    }
}
