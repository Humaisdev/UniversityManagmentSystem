using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class RoomTypeAllocationServices
    {
        private readonly IRoomTypeAllocationRepository _roomTypeAllocationRepository;

        public RoomTypeAllocationServices(IRoomTypeAllocationRepository roomTypeAllocationRepository)
        {
            _roomTypeAllocationRepository = roomTypeAllocationRepository;
        }

        public async Task<RoomTypeAllocation> AddRoomTypeAllocation(RoomTypeAllocationRequestDTO request)
        {
            RoomTypeAllocation allocation = RoomTypeAllocationDTOMapper.RoomTypeAllocationDTOToEntityMapper(request);
            allocation.CreatedAt = DateTime.Now;
            await _roomTypeAllocationRepository.Add(allocation);
            _roomTypeAllocationRepository.Save();
            return allocation;
        }

        public List<RoomTypeAllocationResponseDTO> GetAll()
        {
            List<RoomTypeAllocation> allocations = _roomTypeAllocationRepository.GetAll().ToList();
            return RoomTypeAllocationDTOMapper.RoomTypeAllocationEntityToDTOMapper(allocations);
        }

        public bool RemoveRoomTypeAllocation(int? id)
        {
            RoomTypeAllocation allocation = _roomTypeAllocationRepository.Get(a => a.Id == id);
            if (allocation == null)
            {
                return false;
            }

            _roomTypeAllocationRepository.Remove(allocation);
            _roomTypeAllocationRepository.Save();
            return true;
        }
    }
}
