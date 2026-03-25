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
    public class UserTypeAllocationServices
    {
        private readonly IUserTypeAllocationRepository _userTypeAllocationRepository;

        public UserTypeAllocationServices(IUserTypeAllocationRepository userTypeAllocationRepository)
        {
            _userTypeAllocationRepository = userTypeAllocationRepository;
        }

        public async Task<UserTypeAllocation> AddUserTypeAllocation(UserTypeAllocationRequestDTO request)
        {
            UserTypeAllocation allocation = UserTypeAllocationDTOMapper.UserTypeAllocationDTOToEntityMapper(request);
            allocation.CreatedAt = DateTime.Now;
            await _userTypeAllocationRepository.Add(allocation);
            _userTypeAllocationRepository.Save();
            return allocation;
        }

        public List<UserTypeAllocationResponseDTO> GetAll()
        {
            List<UserTypeAllocation> allocations = _userTypeAllocationRepository.GetAll().ToList();
            return UserTypeAllocationDTOMapper.UserTypeAllocationEntityToDTOMapper(allocations);
        }

        public bool RemoveUserTypeAllocation(int? id)
        {
            UserTypeAllocation allocation = _userTypeAllocationRepository.Get(uta => uta.Id == id);
            if (allocation == null)
            {
                return false;
            }

            _userTypeAllocationRepository.Remove(allocation);
            _userTypeAllocationRepository.Save();
            return true;
        }
    }
}
