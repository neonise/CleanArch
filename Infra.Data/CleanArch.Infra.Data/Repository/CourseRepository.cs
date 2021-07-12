using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System.Collections.Generic;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly MainDbContext context;

        public CourseRepository(MainDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return context.Courses;
        }
    }
}
