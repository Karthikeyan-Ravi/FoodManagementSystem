using FoodManagementSystem.Entity;
using System.Web.Mvc;
using FoodManagementSystem.BL;
using System.Collections.Generic;
using FoodManagementSystem.DAL;
using FoodManagementSystem.Models;

namespace FoodManagementSystem.Controllers
{
    public class UserController : Controller
    {
        IResturant restaurantBL;
        IFoodBL foodBL;
        ICustomerBL customerBL;
        public UserController()
        {
            // Declare an interface instance
            restaurantBL = new RestaurantBL();
            foodBL = new FoodBL();
            customerBL = new CustomerBL();
        }
        public ActionResult DisplayRestaurant()
        {
            IEnumerable<Restaurant> restaurantList = restaurantBL.GetRestaurantDetails();
            return View(restaurantList);
        }
        public ActionResult DisplayFoodItems(int id)
        {
            IEnumerable<FoodItem> restaurantFoods = foodBL.DisplayRestaurantFoods(id);
            return View(restaurantFoods);
        }
        public ActionResult AddToCart(int id, int restaurantId, string mailId)
        {
            FoodItem foodItems = foodBL.GetFoodDetailsById(id);
            Customer customer = customerBL.GetCustomerByMailId(mailId);
            Cart cart = new Cart();
            cart.FoodId = id;
            cart.UserId = customer.UserID;
            customerBL.AddToCart(cart);
            return RedirectToAction("DisplayFoodItems", new {id=restaurantId});
        }
        ////creating an Reference of interface
        //ICustomerBL customerBL;
        //public UserController()
        //{
        //    // Declare an interface instance
        //    customerBL = new CustomerBL();
        //}
        ////GET:SignUp
        //[HttpGet]
        //public ActionResult SignUp() //Method to get the customer details
        //{
        //    return View();
        //}

        //[HttpPost]
        ////POST:SignUp
        //[ValidateAntiForgeryToken]
        //public ActionResult SignUp(UserSignUpViewModel userSignUpViewModel) ////Method to add the customer details to db
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var customerFields = AutoMapper.Mapper.Map<UserSignUpViewModel, Customer>(userSignUpViewModel);
        //        customerBL.SignUpDetails(customerFields);
        //        return RedirectToAction("SignIn");
        //    }
        //    return View();  
        //}
        ////GET:SignIn
        //public ActionResult SignIn()        //Method to get the login details
        //{
        //    return View();
        //}
        ////POST:SignIn
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult SignIn(UserSignInViewModel userSignInViewModel) //Method to check the log in details 
        //{
        //    if(ModelState.IsValid)
        //    {
        //        var customerFields= AutoMapper.Mapper.Map<UserSignInViewModel, Customer>(userSignInViewModel);
        //        //CustomerBL customerBL = new CustomerBL();
        //        Customer customer=customerBL.GetLogInDetails(customerFields);
        //        if(customer!=null)
        //        {
        //            FormsAuthentication.SetAuthCookie(customer.Mail, false);
        //            var authTicket = new FormsAuthenticationTicket(1, customer.Mail, DateTime.Now, DateTime.Now.AddMinutes(20), false, customer.Role);
        //            string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
        //            var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
        //            HttpContext.Response.Cookies.Add(authCookie);
        //            return RedirectToAction("Index", "Home");
        //        }              
        //    }
        //    return View();
        //}
        ////GET:LogOff
        //public ActionResult LogOff()        //Logout method
        //{
        //    FormsAuthentication.SignOut();
        //    return RedirectToAction("Index", "Home");
        //}
    }
}