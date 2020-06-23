using myExercises.Models;
using myExercises.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myExercises.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Method1()
        {
            TempData["Name"] = "Pranaya";
            TempData["Age"] = 30;
            return View();
        }

        public ActionResult Method2()
        {
            string Name;
            int Age;

            if (TempData.ContainsKey("Name"))
            {
                Name = TempData["Name"].ToString();
            }

            if (TempData.ContainsKey("Age"))
            {
                Age = int.Parse(TempData["Age"].ToString());
            }

            // we can’t get the same data in the third request 
            // because TempData will be cleared out after the second request.
            // to retain the TempData value in the third consecutive request,
            // we need to call TempData.Keep() method.
            TempData.Keep();

            return View();
        }
        
        public ActionResult Method3()
        {
            string Name;
            int Age;

            if (TempData.ContainsKey("Name"))
            {
                Name = TempData["Name"].ToString();
            }

            if (TempData.ContainsKey("Age"))
            {
                Age = int.Parse(TempData["Age"].ToString());
            }

            return View();
        }

        // GET: Employee
        public ViewResult Details()
        {
            //Employee Basic Details
            Employee emp = new Employee()
            {
                EmployeeId = 101,
                Name = "Dillip",
                Gender = "Male",
                Department = "IT",
                Salary = 10000,
                AddressId = 1001
            };

            //Employee Address
            Address address = new Address()
            {
                AddressId = 1001,
                City = "Bhubaneswar",
                State = "Odisha",
                Country = "India",
                Pin = "755019"
            };

            //Creating the View model
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Emp = emp,
                Addr = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details",
            };

            //Pass the employeeDetailsViewModel to the view
            return View(employeeDetailsViewModel);
        }
    }
}