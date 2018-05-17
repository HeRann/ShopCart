using DomainModels.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using UserInterface.Security;

namespace UserInterface
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object formuthentication { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            if (authCookie != null)
            {
                FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                if (!authTicket.Expired)
                {
                    UserModel serializeModel = JsonConvert.DeserializeObject<UserModel>(authTicket.UserData);
                    CustomPrincipal newUser = new CustomPrincipal(authTicket.Name);
                    newUser.userName = serializeModel.userName;
                    newUser.password = serializeModel.password;
                    newUser.firstName = serializeModel.firstName;
                    newUser.lastName = serializeModel.lastName;
                    newUser.userId = serializeModel.userId;
                    newUser.contactNumber = serializeModel.contactNumber;
                    newUser.roles = serializeModel.roles;

                    HttpContext.Current.User = newUser;
                }
                else
                {
                    FormsAuthentication.SignOut();
                    Response.Redirect("~/Account/Login");
                }
            }

        }

    }
}
