using Filters.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.App_Start
{
    public class FilterConfig
    {
        public static void RegisterFilters(GlobalFilterCollection filterContext)
        {
            filterContext.Add(new ExceptionFilter());
        }
    }
}