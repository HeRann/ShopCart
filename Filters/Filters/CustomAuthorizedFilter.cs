using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Filters
{
    public class CustomAuthorizedFilter : FilterAttribute, IAuthorizationFilter
    {
        public string  Roles { get; set; }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (!filterContext.HttpContext.User.IsInRole(Roles))
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                    (new { Controller = "Account", action = "Unauthorize", area = "" }));
            }
        }
    }
}