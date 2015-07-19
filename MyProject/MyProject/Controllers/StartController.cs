using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BusinessLogic;
using Domain;

namespace MyProject.Controllers
{
    public class StartController : Controller
    {
        //
        // GET: /Start/
        [AllowAnonymous]
        public ActionResult Start()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken,AllowAnonymous]
        public ActionResult Start(Authentication model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            else
            {
                var user = ServiceFactory.Resolve<IUserService>().Authenticate(model.Login, model.Password);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Login, true);
                    string log= user.FirstName + user.LastName;
                    var httpCookie = Response.Cookies["Log"];
                    if (httpCookie != null) httpCookie.Value = log;
                    return RedirectToAction("Index", "Home");
                }
           
                ModelState.AddModelError( "Password","Invalid login or password.");
                return View();
            }
        }

        [HttpGet,AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Register(Registration model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Key", "Invalid login or password.");
            
            return View();
             }

    else
            {
                
                ServiceFactory.Resolve<IUserService>().Create(model, model.Password);
                ServiceFactory.Resolve<IUserService>().Authenticate(model.Login, model.Password);
                FormsAuthentication.SetAuthCookie(model.Login, true);
               string log = model.FirstName + model.LastName;
               var httpCookie = Response.Cookies["Log"];
               if (httpCookie != null) httpCookie.Value = log;
                return RedirectToAction("Index", "Home");
            
            }
                
            
         
        }

    }
}
