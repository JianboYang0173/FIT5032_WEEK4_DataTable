﻿using System.Web;
using System.Web.Mvc;

namespace FIT5032_WEEK4_DataTable
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
