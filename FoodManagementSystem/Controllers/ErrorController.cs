using System.Web.Mvc;

namespace FoodManagementSystem.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult ErrorMessage()
        {
            return View();
        }
    }
}