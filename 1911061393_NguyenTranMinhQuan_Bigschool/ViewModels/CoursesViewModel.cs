﻿using _1911061393_NguyenTranMinhQuan_Bigschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1911061393_NguyenTranMinhQuan_Bigschool.ViewModels
{
    public class CoursesViewModel
    {
        
            public IEnumerable<Course> UpcommingCourses { get; set; }

           public bool ShowAction { get; set; }
        public IEnumerable<Attendance> IsFollowCourses { get; set; }
        public IEnumerable<Following> IsFollowLecturers { get; set; }

    }
}