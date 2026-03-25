using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class RoomServices
    {
        private readonly IRoomRepository _roomRepository;

        public RoomServices(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<Room> AddRoom(RoomRequestDTO request)
        {
            Room room = RoomDTOMapper.RoomDTOToEntityMapper(request);
            room.CreatedAt = DateTime.Now;
            await _roomRepository.Add(room);
            _roomRepository.Save();
            return room;
        }

        public List<RoomResponseDTO> GetAll()
        {
            List<Room> rooms = _roomRepository.GetAll().ToList();
            return RoomDTOMapper.RoomEntityToDTOMapper(rooms);
        }

        public bool RemoveRoom(int? id)
        {
            Room room = _roomRepository.Get(r => r.Id == id);
            if (room == null)
            {
                return false;
            }

            _roomRepository.Remove(room);
            _roomRepository.Save();
            return true;
        }
    }
}
