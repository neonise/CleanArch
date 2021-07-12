using CleanArch.Domain.Models;
using System.Collections.Generic;

namespace CleanArch.Application.ViewModels
{
    public class CourceViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
