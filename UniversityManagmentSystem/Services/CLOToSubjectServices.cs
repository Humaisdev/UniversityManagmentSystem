using UniversityManagementSystem.Interfaces;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class CLOToSubjectServices
    {
        private readonly ICLOToSubjectRepository _cloToSubjectRepository;

        public CLOToSubjectServices(ICLOToSubjectRepository cloToSubjectRepository)
        {
            _cloToSubjectRepository = cloToSubjectRepository;
        }

        public async Task<CLOToSubject> AddCLOToSubject(CLOToSubjectRequestDTO request)
        {
            CLOToSubject entity = CLOToSubjectDTOMapper.CLOToSubjectDTOToEntityMapper(request);
            entity.CreatedAt = DateTime.Now;
            await _cloToSubjectRepository.Add(entity);
            _cloToSubjectRepository.Save();
            return entity;
        }

        public List<CLOToSubjectResponseDTO> GetAll()
        {
            List<CLOToSubject> entities = _cloToSubjectRepository.GetAll().ToList();
            return CLOToSubjectDTOMapper.CLOToSubjectEntityToDTOMapper(entities);
        }

        public bool RemoveCLOToSubject(int? id)
        {
            CLOToSubject entity = _cloToSubjectRepository.Get(c => c.Id == id);
            if (entity == null)
            {
                return false;
            }

            _cloToSubjectRepository.Remove(entity);
            _cloToSubjectRepository.Save();
            return true;
        }
    }
}
