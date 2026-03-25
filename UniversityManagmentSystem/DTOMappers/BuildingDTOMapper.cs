using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class BuildingDTOMapper
    {
        public static Building BuildingDTOToEntityMapper(BuildingRequestDTO dto)
        {
            Building building = new Building();
            building.Name = dto.Name;
            building.Description = dto.Description;
            building.EstablishedIn = dto.EstablishedIn;
            building.Address = dto.Address;
            building.CampusId = dto.CampusId;
            return building;
        }

        public static Building BuildingEntityToDTOMapper(Building building, BuildingRequestDTO dto)
        {
            building.Id = dto.Id;
            building.Name = dto.Name;
            building.Description = dto.Description;
            building.EstablishedIn = dto.EstablishedIn;
            building.Address = dto.Address;
            building.CampusId = dto.CampusId;
            return building;
        }

        public static BuildingResponseDTO EntityToBuildingDTO(Building building)
        {
            BuildingResponseDTO dto = new BuildingResponseDTO();
            dto.Id = building.Id;
            dto.Name = building.Name;
            dto.Description = building.Description;
            dto.EstablishedIn = building.EstablishedIn;
            dto.Address = building.Address;
            dto.CampusId = building.CampusId;
            dto.CreatedAt = building.CreatedAt;
            dto.UpdatedAt = building.UpdatedAt;
            dto.GlobalId = building.GlobalId;
            return dto;
        }

        public static List<BuildingResponseDTO> BuildingEntityToDTOMapper(List<Building> buildings)
        {
            List<BuildingResponseDTO> dtos = new List<BuildingResponseDTO>();
            foreach (Building building in buildings)
            {
                dtos.Add(EntityToBuildingDTO(building));
            }
            return dtos;
        }
    }
}
