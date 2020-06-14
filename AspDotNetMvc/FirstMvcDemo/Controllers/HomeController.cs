using FirstMvcDemo.Models;
using FirstMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id)
        {
            EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
            Employee employee = employeeBL.GetEmployeeDetails(id);
            return View();
        }
    }
}