using Entities;
namespace Services
{
    public interface ICourseService
    {
        Course GetCourseByID(long courseID);
    }
}
