using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myExercises.Models.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public Employee Emp { get; set; }
        public Address Addr { get; set; }
        public string PageTitle { get; set; }
        public string PageHeader { get; set; }
    }
}