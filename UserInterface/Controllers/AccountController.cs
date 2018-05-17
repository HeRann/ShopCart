using DomainModels.ViewModel;
using Newtonsoft.Json;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace UserInterface.Controllers
{
    public class AccountController : Controller
    {
        IUnitOfWork uow;
        public AccountController(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            UserModel user = uow.AuthenticateRepo.validateUser(model.userName, model.password);
            if (user != null)
            {
                string data = JsonConvert.SerializeObject(user);
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, user.userName, DateTime.Now, DateTime.Now.AddMinutes(20),false,data);
                string encTicket = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName,encTicket);
                Response.Cookies.Add(cookie);

                if (user.roles.Contains("Admin"))
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else if(user.roles.Contains("User"))
                {
                    return RedirectToAction("Index", "Home", new { area = "User" });
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }

        public ActionResult UnAuthorize()
        {
            return View();
        }
    }
}