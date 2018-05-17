using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInterface.Security;

namespace UserInterface.Areas.Admin.Controllers
{
    [CustomAuthenticationFilter]
    [CustomAuthorizedFilter(Roles = "Admin")]

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