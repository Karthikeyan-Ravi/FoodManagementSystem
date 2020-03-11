using FoodManagementSystem.Entity;
using FoodManagementSystem.Models;
using FoodManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCuisine()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCuisine(CuisineViewModel cuisineViewModel)
        {
            if(ModelState.IsValid)
            {
                CuisineBL cuisineBL = new CuisineBL();
                Cuisine cuisine = new Cuisine();
                cuisine.CuisineName = cuisineViewModel.CuisineName;
                cuisineBL.AddCuisine(cuisine); 
            }
            return View();
        }
    }
}