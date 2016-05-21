using Entities;
namespace Services
{
    public class CourseService : ICourseService
    {
        public Course GetCourseByID(long courseID)
        {
            return new Course { CourseID = courseID, Description = "Sample course description", InstitutionID = 1, Title = "Sample Course Title" };
        }
    }
}
