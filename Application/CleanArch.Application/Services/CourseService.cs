using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        private readonly IMediatorHandler mediatorHandler;

        public CourseService(ICourseRepository courseRepository,
            IMediatorHandler mediatorHandler)
        {
            this.courseRepository = courseRepository;
            this.mediatorHandler = mediatorHandler;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImageUrl
            );

            mediatorHandler.SendCommand(createCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = courseRepository.GetCourses()
            };
        }
    }
}
