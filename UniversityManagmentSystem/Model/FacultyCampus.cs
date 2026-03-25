using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class FacultyCampus : BaseModel
    {
        public int FacultyId { get; set; }
        Faculty Faculty { get; set; }
        public int CampusId { get; set; }
        Campus Campus { get; set; }
        public List<Institute> Institute { get; set; }
    }
}
