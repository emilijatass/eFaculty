using Faculty.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFaculty.ViewModels
{
    public class CourseStudentVM
    {

        public Student Student { get; set; }
        public IEnumerable<int> SelectedCourses { get; set; }
        public IEnumerable<SelectListItem> CourseList { get; set; }
    }
}
