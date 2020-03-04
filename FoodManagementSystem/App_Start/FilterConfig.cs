using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FoodManagementSystem.App_Start
{
    public class FilterConfig
    {
        public static void GlobalFilter(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()); 
        }

    }
}