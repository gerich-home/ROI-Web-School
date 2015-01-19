using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class ClientController : Controller
    {
        //
        // GET: /Client/

        [Authorize]
        public ActionResult Edit()
        {
            throw new NotImplementedException();
        }

        [Authorize]
        public ActionResult Add()
        {

            return View();
        }


    }
}
