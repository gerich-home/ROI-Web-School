using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using BusinessLogic;
using Data1;
using Data1.Entities;
using Domain;
using Microsoft.Ajax.Utilities;


namespace MyProject.Controllers
{   
    public class HomeController : Controller
    {
        //
        // GET: /Home/
      
        [HttpGet, Authorize]
        public ActionResult Index()
        {
            IndexView my =new IndexView();
            int count = 0;
            MyContext con = new MyContext();
            var clients = con.Clients.Include(p=>p.Operations);
            foreach (var t in clients)
            {
                my.Name = t.FirstName + " " + t.LastName;
                my.Age = Convert.ToInt32(DateTime.Now - t.DateOfBirth);
                my.Status = Convert.ToString(t.Operations.Type);
                my.Call = t.Operations.Callback;
                count++;
            }
            if(count!=0)
            {
                return View();
            }
            else
            {
                ViewBag.Error = "Data isn't exist. Please, add data";
                return RedirectToAction("Add", "Client");
            }
            
        }

        public ActionResult Logout()
        {
            Request.Cookies.Remove("Log");
            FormsAuthentication.SignOut();
            return RedirectToAction("Start", "Start");
        }
    }
}
