using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class CourseScheme : BaseModel
    {
        public int SubjectId { get; set; }
        Subject Subject { get; set; }
        public int SubjectTypeId { get; set; }
        SubjectType SubjectType { get; set; }
        public int CreditHours { get; set; }
        public int DegreeProgramId { get; set; }
        DegreeProgram DegreeProgram { get; set; }
        public int ProgramSessionId { get; set; }
        ProgramSession ProgramSession { get; set; }
        public int SemesterId { get; set; }
        Semester Semester { get; set; }
    }
}
