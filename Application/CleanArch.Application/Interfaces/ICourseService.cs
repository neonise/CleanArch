using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        void Create(CourseViewModel courseViewModel);
        CourseViewModel GetCourses();
    }
}
