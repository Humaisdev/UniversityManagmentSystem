using UniversityManagementSystem.Interfaces;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.Repositories;

namespace UniversityManagmentSystem.Services
{
    public class UserRightServices
    {
        private readonly IUserRightRepository _userRightRepository;

        public UserRightServices(IUserRightRepository userRightRepository)
        {
            _userRightRepository = userRightRepository;
        }

        public async Task<UserRight> AddUserRight(UserRightRequestDTO request)
        {
            UserRight userRight = UserRightDTOMapper.UserRightDTOToEntityMapper(request);
            userRight.CreatedAt = DateTime.Now;
            await _userRightRepository.Add(userRight);
            _userRightRepository.Save();
            return userRight;
        }

        public List<UserRightResponseDTO> GetAll()
        {
            List<UserRight> userRights = _userRightRepository.GetAll().ToList();
            return UserRightDTOMapper.UserRightEntityToDTOMapper(userRights);
        }

        public bool RemoveUserRight(int? id)
        {
            UserRight userRight = _userRightRepository.Get(ur => ur.Id == id);
            if (userRight == null)
            {
                return false;
            }

            _userRightRepository.Remove(userRight);
            _userRightRepository.Save();
            return true;
        }
    }
}
