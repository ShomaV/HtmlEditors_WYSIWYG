﻿using System.Web;
using System.Web.Mvc;

namespace TinyMCE_MVC_Sample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
