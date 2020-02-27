using FoodManagementSystem.Entity;
using FoodManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodManagementSystem.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            RestaurantRepository restaurantRepository = new RestaurantRepository();
            restaurantRepository.GetRestaurantDetails();
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SignUp(CustomerFields customer)
        {
            if (ModelState.IsValid)
            {
                return View(customer);
            }

            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
    }
}