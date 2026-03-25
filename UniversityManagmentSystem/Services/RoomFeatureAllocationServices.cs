using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class RoomFeatureAllocationServices
    {
        private readonly IRoomFeatureAllocationRepository _roomFeatureAllocationRepository;

        public RoomFeatureAllocationServices(IRoomFeatureAllocationRepository roomFeatureAllocationRepository)
        {
            _roomFeatureAllocationRepository = roomFeatureAllocationRepository;
        }

        public async Task<RoomFeatureAllocation> AddRoomFeatureAllocation(RoomFeatureAllocationRequestDTO request)
        {
            RoomFeatureAllocation allocation = RoomFeatureAllocationDTOMapper.RoomFeatureAllocationDTOToEntityMapper(request);
            allocation.CreatedAt = DateTime.Now;
            await _roomFeatureAllocationRepository.Add(allocation);
            _roomFeatureAllocationRepository.Save();
            return allocation;
        }

        public List<RoomFeatureAllocationResponseDTO> GetAll()
        {
            List<RoomFeatureAllocation> allocations = _roomFeatureAllocationRepository.GetAll().ToList();
            return RoomFeatureAllocationDTOMapper.RoomFeatureAllocationEntityToDTOMapper(allocations);
        }

        public bool RemoveRoomFeatureAllocation(int? id)
        {
            RoomFeatureAllocation allocation = _roomFeatureAllocationRepository.Get(a => a.Id == id);
            if (allocation == null)
            {
                return false;
            }

            _roomFeatureAllocationRepository.Remove(allocation);
            _roomFeatureAllocationRepository.Save();
            return true;
        }
    }
}
