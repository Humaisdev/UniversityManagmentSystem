using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class CLOToSubject : BaseModel

    {
        public int CLOId { get; set; }
        public CLO CLO { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int ProgramSessionId { get; set; }
        public ProgramSession ProgramSession { get; set; }

    }
}
