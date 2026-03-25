using UniversityManagementSystem.Interfaces;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class StructureUnitServices
    {
        private readonly IStructureUnitRepository _structureUnitRepository;

        public StructureUnitServices(IStructureUnitRepository structureUnitRepository)
        {
            _structureUnitRepository = structureUnitRepository;
        }

        public async Task<StructureUnit> AddStructureUnit(StructureUnitRequestDTO request)
        {
            StructureUnit unit = StructureUnitDTOMapper.StructureUnitDTOToEntityMapper(request);
            unit.CreatedAt = DateTime.Now;
            await _structureUnitRepository.Add(unit);
            _structureUnitRepository.Save();
            return unit;
        }

        public List<StructureUnitResponseDTO> GetAll()
        {
            List<StructureUnit> units = _structureUnitRepository.GetAll().ToList();
            return StructureUnitDTOMapper.StructureUnitEntityToDTOMapper(units);
        }

        public bool RemoveStructureUnit(int? id)
        {
            StructureUnit unit = _structureUnitRepository.Get(u => u.Id == id);
            if (unit == null)
            {
                return false;
            }

            _structureUnitRepository.Remove(unit);
            _structureUnitRepository.Save();
            return true;
        }
    }
}
