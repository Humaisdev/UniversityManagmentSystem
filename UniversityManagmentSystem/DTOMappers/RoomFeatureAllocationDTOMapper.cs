using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class RoomFeatureAllocationDTOMapper
    {
        public static RoomFeatureAllocation RoomFeatureAllocationDTOToEntityMapper(RoomFeatureAllocationRequestDTO dto)
        {
            RoomFeatureAllocation entity = new RoomFeatureAllocation();
            entity.RoomId = dto.RoomId;
            entity.RoomFeatureId = dto.RoomFeatureId;
            entity.Quantity = dto.Quantity;
            return entity;
        }

        public static RoomFeatureAllocation RoomFeatureAllocationEntityToDTOMapper(RoomFeatureAllocation entity, RoomFeatureAllocationRequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.RoomId = dto.RoomId;
            entity.RoomFeatureId = dto.RoomFeatureId;
            entity.Quantity = dto.Quantity;
            return entity;
        }

        public static RoomFeatureAllocationResponseDTO EntityToRoomFeatureAllocationDTO(RoomFeatureAllocation entity)
        {
            RoomFeatureAllocationResponseDTO dto = new RoomFeatureAllocationResponseDTO();
            dto.Id = entity.Id;
            dto.RoomId = entity.RoomId;
            dto.RoomFeatureId = entity.RoomFeatureId;
            dto.Quantity = entity.Quantity;
            dto.CreatedAt = entity.CreatedAt;
            dto.UpdatedAt = entity.UpdatedAt;
            dto.GlobalId = entity.GlobalId;
            return dto;
        }

        public static List<RoomFeatureAllocationResponseDTO> RoomFeatureAllocationEntityToDTOMapper(List<RoomFeatureAllocation> entities)
        {
            List<RoomFeatureAllocationResponseDTO> dtos = new List<RoomFeatureAllocationResponseDTO>();
            foreach (RoomFeatureAllocation entity in entities)
            {
                dtos.Add(EntityToRoomFeatureAllocationDTO(entity));
            }
            return dtos;
        }
    }
}
