using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class RoomTypeAllocationDTOMapper
    {
        public static RoomTypeAllocation RoomTypeAllocationDTOToEntityMapper(RoomTypeAllocationRequestDTO dto)
        {
            RoomTypeAllocation entity = new RoomTypeAllocation();
            entity.RoomId = dto.RoomId;
            entity.RoomTypeId = dto.RoomTypeId;
            return entity;
        }

        public static RoomTypeAllocation RoomTypeAllocationEntityToDTOMapper(RoomTypeAllocation entity, RoomTypeAllocationRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.RoomId = dto.RoomId;
            entity.RoomTypeId = dto.RoomTypeId;
            return entity;
        }

        public static RoomTypeAllocationResponseDTO EntityToRoomTypeAllocationDTO(RoomTypeAllocation entity)
        {
            RoomTypeAllocationResponseDTO dto = new RoomTypeAllocationResponseDTO();
            dto.Id = entity.Id;
            dto.RoomId = entity.RoomId;
            dto.RoomTypeId = entity.RoomTypeId;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<RoomTypeAllocationResponseDTO> RoomTypeAllocationEntityToDTOMapper(List<RoomTypeAllocation> entities)
        {
            List<RoomTypeAllocationResponseDTO> dtos = new List<RoomTypeAllocationResponseDTO>();
            foreach (RoomTypeAllocation entity in entities)
            {
                dtos.Add(EntityToRoomTypeAllocationDTO(entity));
            }
            return dtos;
        }
    }
}
