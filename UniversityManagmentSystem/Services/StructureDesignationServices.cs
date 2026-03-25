using UniversityManagementSystem.Interfaces;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class StructureDesignationServices
    {
        private readonly IStructureDesignationRepository _structureDesignationRepository;

        public StructureDesignationServices(IStructureDesignationRepository structureDesignationRepository)
        {
            _structureDesignationRepository = structureDesignationRepository;
        }

        public async Task<StructureDesignation> AddStructureDesignation(StructureDesignationRequestDTO request)
        {
            StructureDesignation designation = StructureDesignationDTOMapper.StructureDesignationDTOToEntityMapper(request);
            designation.CreatedAt = DateTime.Now;
            await _structureDesignationRepository.Add(designation);
            _structureDesignationRepository.Save();
            return designation;
        }

        public List<StructureDesignationResponseDTO> GetAll()
        {
            List<StructureDesignation> designations = _structureDesignationRepository.GetAll().ToList();
            return StructureDesignationDTOMapper.StructureDesignationEntityToDTOMapper(designations);
        }

        public bool RemoveStructureDesignation(int? id)
        {
            StructureDesignation designation = _structureDesignationRepository.Get(d => d.Id == id);
            if (designation == null)
            {
                return false;
            }

            _structureDesignationRepository.Remove(designation);
            _structureDesignationRepository.Save();
            return true;
        }
    }
}