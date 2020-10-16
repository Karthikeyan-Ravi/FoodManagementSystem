using FoodManagementSystem.BL;
using FoodManagementSystem.Entity;
using FoodManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FoodManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        //creating an Reference of interface
        ICustomerBL customerBL;
        public AccountController()
        {
            // Declare an interface instance
            customerBL = new CustomerBL();
        }
        //GET:SignUp
        [HttpGet]
        public ActionResult SignUp() //Method to get the customer details
        {
            return View();
        }

        [HttpPost]
        //POST:SignUp
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(UserSignUpViewModel userSignUpViewModel) ////Method to add the customer details to db
        {
            if (ModelState.IsValid)
            {
                var customerFields = AutoMapper.Mapper.Map<UserSignUpViewModel, Customer>(userSignUpViewModel);
                customerBL.SignUpDetails(customerFields);
                return RedirectToAction("SignIn");
            }
            return View();
        }
        //GET:SignIn
        public ActionResult SignIn()        //Method to get the login details
        {
            return View();
        }
        //POST:SignIn
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(UserSignInViewModel userSignInViewModel) //Method to check the log in details 
        {
            if (ModelState.IsValid)
            {
                var customerFields = AutoMapper.Mapper.Map<UserSignInViewModel, Customer>(userSignInViewModel);
                //CustomerBL customerBL = new CustomerBL();
                Customer customer = customerBL.GetLogInDetails(customerFields);
                if (customer != null)
                {
                    FormsAuthentication.SetAuthCookie(customer.Mail, false);
                    var authTicket = new FormsAuthenticationTicket(1, customer.Mail, DateTime.Now, DateTime.Now.AddMinutes(20), false, customer.Role);
                    string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    HttpContext.Response.Cookies.Add(authCookie);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        //GET:LogOff
        public ActionResult LogOff()        //Logout method
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}