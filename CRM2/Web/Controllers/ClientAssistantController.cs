using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Crm.Controllers
{
    public class ClientAssistantController : Controller
    {
        //
        // GET: /ClientAssistant/

        public ActionResult Index()
        {
            return View();
        }

    }
}
