using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myExercises.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            Employee employee = new Employee()
            {
                EmployeeId = EmployeeId,
                Name = "Pranaya",
                Gender = "Male",
                City = "Mumbai",
                Salary = 1000,
                Address = "Andheri"
            };

            return employee;
        }
    }
}