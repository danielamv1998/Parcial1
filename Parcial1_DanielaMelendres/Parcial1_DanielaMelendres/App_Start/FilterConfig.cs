﻿using System.Web;
using System.Web.Mvc;

namespace Parcial1_DanielaMelendres
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
