using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public CourceViewModel GetCourses()
        {
            return new CourceViewModel
            {
                Courses = courseRepository.GetCourses()
            };
        }
    }
}
