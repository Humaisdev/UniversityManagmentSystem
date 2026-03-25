using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class CLOToSubjectDTOMapper
    {
        public static CLOToSubject CLOToSubjectDTOToEntityMapper(CLOToSubjectRequestDTO dto)
        {
            CLOToSubject cloToSubject = new CLOToSubject();
            cloToSubject.CLOId = dto.CLOId;
            cloToSubject.SubjectId = dto.SubjectId;
            cloToSubject.ProgramSessionId = dto.ProgramSessionId;
            return cloToSubject;
        }

        public static CLOToSubject CLOToSubjectEntityToDTOMapper(CLOToSubject cloToSubject, CLOToSubjectRequestDTO dto)
        {
            cloToSubject.Id = dto.Id;
            cloToSubject.CLOId = dto.CLOId;
            cloToSubject.SubjectId = dto.SubjectId;
            cloToSubject.ProgramSessionId = dto.ProgramSessionId;
            return cloToSubject;
        }

        public static CLOToSubjectResponseDTO EntityToCLOToSubjectDTO(CLOToSubject cloToSubject)
        {
            CLOToSubjectResponseDTO dto = new CLOToSubjectResponseDTO();
            dto.Id = cloToSubject.Id;
            dto.CLOId = cloToSubject.CLOId;
            dto.SubjectId = cloToSubject.SubjectId;
            dto.ProgramSessionId = cloToSubject.ProgramSessionId;
            dto.CreatedAt = cloToSubject.CreatedAt;
            dto.UpdatedAt = cloToSubject.UpdatedAt;
            dto.GlobalId = cloToSubject.GlobalId;
            return dto;
        }

        public static List<CLOToSubjectResponseDTO> CLOToSubjectEntityToDTOMapper(List<CLOToSubject> cloToSubjects)
        {
            List<CLOToSubjectResponseDTO> dtos = new List<CLOToSubjectResponseDTO>();
            foreach (CLOToSubject cloToSubject in cloToSubjects)
            {
                dtos.Add(EntityToCLOToSubjectDTO(cloToSubject));
            }
            return dtos;
        }
    }
}
