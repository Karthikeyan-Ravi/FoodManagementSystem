using FoodManagementSystem.Entity;
using FoodManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodManagementSystem.Models;
using FoodManagementSystem.BL;

namespace FoodManagementSystem.Controllers
{
    [HandleError]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            //RestaurantRepository restaurantRepository = new RestaurantRepository();
            //restaurantRepository.GetRestaurantDetails();
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {

            return View();
        }

        [HttpPost]
        //[ActionName("SignUp")]
        public ActionResult SignUp(UserSignUpViewModel userSignUpViewModel)
        {

            if (ModelState.IsValid)
            {
                var customerFields = AutoMapper.Mapper.Map<UserSignUpViewModel, CustomerFields>(userSignUpViewModel);
                CustomerBL customerBL = new CustomerBL();
                customerBL.GetSignUpDetails(customerFields);
            }

            return RedirectToAction("SignIn");
        }
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(UserSignInViewModel userSignInViewModel)
        {
            if(ModelState.IsValid)
            {
                var customerFields= AutoMapper.Mapper.Map<UserSignInViewModel, CustomerFields>(userSignInViewModel);
                CustomerBL customerBL = new CustomerBL();
                string role=customerBL.GetLogInDetails(customerFields);
                if(role=="Admin")
                {
                    return RedirectToAction("Index", "Restaurant");
                }
                else if(role=="User")
                {

                }
                else
                {
                    Response.Write("Invalid Email and Password");
                }
            }
            return View();
        }
        
    }
}