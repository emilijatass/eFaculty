﻿
using Faculty.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFaculty.ViewModels
{
    public class EnrollUnEnrollVM
    {
        public Enrollment NewEnrollStudent { get; set; }
        public IEnumerable<int> SelectedStudents { get; set; }
        public IEnumerable<SelectListItem> StudentsList { get; set; }
    }
}
