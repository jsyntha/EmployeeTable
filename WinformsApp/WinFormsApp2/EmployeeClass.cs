﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class EmployeeClass
    {
       
        public int EmId { get; set; }
        public string EmpName { get; set; }
        public string EmpPosition { get; set; }
        public int EmpSalary { get; set; }

      
        public EmployeeClass(int emId, string empName, string empPosition, int empSalary)
        {
            EmId = emId;
            EmpName = empName;
            EmpPosition = empPosition;
            EmpSalary = empSalary;

        }
    }

}
