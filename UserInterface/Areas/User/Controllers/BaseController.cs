using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInterface.Security;

namespace UserInterface.Areas.User.Controllers
{
    [CustomAuthenticationFilter]
    [CustomAuthorizedFilter(Roles = "User")]
    public class BaseController : Controller
    {
        public CustomPrincipal currentUser
        {
            get
            {
                return (CustomPrincipal)HttpContext.User;
            }
        }
    }
}