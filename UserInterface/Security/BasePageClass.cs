using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Security
{
    public abstract class BasePageClass: WebViewPage
    {
        public CustomPrincipal currentUser
        {
            get
            {
                return (CustomPrincipal)HttpContext.Current.User;
            }
        }
    }

    public abstract class BasePageClass<TModel> : WebViewPage<TModel>
    {
        public CustomPrincipal currentUser
        {
            get
            {
                return (CustomPrincipal)HttpContext.Current.User;
            }
        }
    }
}