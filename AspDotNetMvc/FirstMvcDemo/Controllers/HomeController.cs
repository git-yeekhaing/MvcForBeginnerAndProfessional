using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        //http://localhost:xxxx/Home/Index/10?name=James
        // GET: Home
        public string Index(int id, string name)
        {
            return "the value of Id = " + id + " and Name = " + Request.QueryString["name"];
        }
    }
}