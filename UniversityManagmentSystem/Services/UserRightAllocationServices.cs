using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.Repositories;

namespace UniversityManagmentSystem.Services
{
    public class UserRightAllocationServices
    {
        private readonly IUserRightAllocationRepository _userRightAllocationRepository;

        public UserRightAllocationServices(IUserRightAllocationRepository userRightAllocationRepository)
        {
            _userRightAllocationRepository = userRightAllocationRepository;
        }

        public async Task<UserRightAllocation> AddUserRightAllocation(UserRightAllocationRequestDTO request)
        {
            UserRightAllocation allocation = UserRightAllocationDTOMapper.UserRightAllocationDTOToEntityMapper(request);
            allocation.CreatedAt = DateTime.Now;
            await _userRightAllocationRepository.Add(allocation);
            _userRightAllocationRepository.Save();
            return allocation;
        }

        public List<UserRightAllocationResponseDTO> GetAll()
        {
            List<UserRightAllocation> allocations = _userRightAllocationRepository.GetAll().ToList();
            return UserRightAllocationDTOMapper.UserRightAllocationEntityToDTOMapper(allocations);
        }

        public bool RemoveUserRightAllocation(int? id)
        {
            UserRightAllocation allocation = _userRightAllocationRepository.Get(ur => ur.Id == id);
            if (allocation == null)
            {
                return false;
            }

            _userRightAllocationRepository.Remove(allocation);
            _userRightAllocationRepository.Save();
            return true;
        }
    }
}
