using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class CampusServices
    {
        private readonly ICampusRepository _campusRepository;

        public CampusServices(ICampusRepository campusRepository)
        {
            _campusRepository = campusRepository;
        }

        public async Task<Campus> AddCampus(CampusRequestDTO request)
        {
            Campus campus = CampusDTOMapper.CampusDTOToEntityMapper(request);
            campus.CreatedAt = DateTime.Now;
            await _campusRepository.Add(campus);
            _campusRepository.Save();
            return campus;
        }

        public List<CampusResponseDTO> GetAll()
        {
            List<Campus> campuses = _campusRepository.GetAll().ToList();
            return CampusDTOMapper.CampusEntityToDTOMapper(campuses);
        }

        public bool RemoveCampus(int? id)
        {
            Campus campus = _campusRepository.Get(c => c.Id == id);
            if (campus == null)
            {
                return false;
            }

            _campusRepository.Remove(campus);
            _campusRepository.Save();
            return true;
        }
    }
}
