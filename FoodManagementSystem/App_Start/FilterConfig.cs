using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace FoodManagementSystem.App_Start
{
    public class FilterConfig
    {
        public static void GlobalFilter(GlobalFilterCollection filters)
        {
            filters.Add(new CustomException());
        }
    }
    public class CustomException : FilterAttribute, IExceptionFilter
    {
        StringBuilder message = new StringBuilder();

        public void OnException(ExceptionContext filterContext)
        {
            message.Append(filterContext.RouteData.Values["controller"].ToString());
            message.Append(" ---> ");
            message.Append(filterContext.RouteData.Values["action"].ToString());
            message.Append(" ---> ");
            message.Append(filterContext.Exception.Message);
            message.Append(" ---> ");
            message.AppendLine(DateTime.Now.ToString());
            LogMessage(message.ToString());
            message.Clear();
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
        }
        protected void LogMessage(string message)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/Logger/Exception_Logger.txt"), message);
        }
    }
}