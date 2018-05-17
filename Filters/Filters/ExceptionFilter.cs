using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Filters
{
    public class ExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            string exMessage = filterContext.Exception.Message;
            filterContext.HttpContext.Response.Write(exMessage + "<br/>");
        }
    }
}