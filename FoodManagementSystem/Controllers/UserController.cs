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
                CustomerFields customerFields = new CustomerFields();
                customerFields.FullName = userSignUpViewModel.FullName;
                customerFields.Mail = userSignUpViewModel.Mail;
                customerFields.Password = userSignUpViewModel.Password;
                customerFields.PhoneNumber = userSignUpViewModel.PhoneNumber;
                customerFields.Role = userSignUpViewModel.Role;
                CustomerBL customerBL = new CustomerBL();
                customerBL.GetSignUpDetails(customerFields);
            }

            return View();
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
                CustomerFields customerFields = new CustomerFields();
                customerFields.Mail = userSignInViewModel.Mail;
                customerFields.Password = userSignInViewModel.Password;
                CustomerBL customerBL = new CustomerBL();
                string role=customerBL.GetLogInDetails(customerFields);
                if(role=="Admin")
                {
                    Response.Write("Login successful");
                }
                else
                {

                }
            }
            return View();
        }
        
    }
}