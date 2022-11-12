﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.Models
{
    public class Teacher
    {
        //Varaibles
        public int teacherId;
        public string teacherFname;
        public string teacherLname;
        public string employeeNumber;
        public string hireDate;
        public float salary;

        //Constructor
        public Teacher(int _teacherId = -1, string _teacherFname = null, string _teacherLname = null, string _employeeNumber = null, string _hireDate = null, float _salary = 0)
        {
            teacherId = _teacherId;
            teacherFname = _teacherFname;
            teacherLname = _teacherLname;
            employeeNumber = _employeeNumber;
            hireDate = _hireDate;
            salary = _salary;
        }

    }
}