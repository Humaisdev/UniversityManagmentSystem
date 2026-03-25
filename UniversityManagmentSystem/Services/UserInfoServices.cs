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
    public class UserInfoServices
    {
        private readonly IUserInfoRepository _userInfoRepository;

        public UserInfoServices(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }

        public async Task<UserInfo> AddUserInfo(UserInfoRequestDTO request)
        {
            UserInfo userInfo = UserInfoDTOMapper.UserInfoDTOToEntityMapper(request);
            userInfo.CreatedAt = DateTime.Now;
            await _userInfoRepository.Add(userInfo);
            _userInfoRepository.Save();
            return userInfo;
        }

        public List<UserInfoResponseDTO> GetAll()
        {
            List<UserInfo> users = _userInfoRepository.GetAll().ToList();
            return UserInfoDTOMapper.UserInfoEntityToDTOMapper(users);
        }

        public bool RemoveUserInfo(int? id)
        {
            UserInfo user = _userInfoRepository.Get(u => u.Id == id);
            if (user == null)
            {
                return false;
            }

            _userInfoRepository.Remove(user);
            _userInfoRepository.Save();
            return true;
        }
    }
}
