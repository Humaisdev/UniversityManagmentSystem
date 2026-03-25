using UniversityManagementSystem.Interfaces;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class LearningTypeServices
    {
        private readonly ILearningTypeRepository _learningTypeRepository;

        public LearningTypeServices(ILearningTypeRepository learningTypeRepository)
        {
            _learningTypeRepository = learningTypeRepository;
        }

        public async Task<LearningType> AddLearningType(LearningTypeRequestDTO request)
        {
            LearningType learningType = LearningTypeDTOMapper.LearningTypeDTOToEntityMapper(request);
            learningType.CreatedAt = DateTime.Now;
            await _learningTypeRepository.Add(learningType);
            _learningTypeRepository.Save();
            return learningType;
        }

        public List<LearningTypeResponseDTO> GetAll()
        {
            List<LearningType> learningTypes = _learningTypeRepository.GetAll().ToList();
            return LearningTypeDTOMapper.LearningTypeEntityToDTOMapper(learningTypes);
        }

        public bool RemoveLearningType(int? id)
        {
            LearningType learningType = _learningTypeRepository.Get(lt => lt.Id == id);
            if (learningType == null)
            {
                return false;
            }

            _learningTypeRepository.Remove(learningType);
            _learningTypeRepository.Save();
            return true;
        }
    }
}
