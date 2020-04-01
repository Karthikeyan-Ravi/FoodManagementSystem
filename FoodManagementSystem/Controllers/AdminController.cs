using FoodManagementSystem.Entity;
using FoodManagementSystem.Models;
using FoodManagementSystem.BL;
using System.Collections.Generic;
using System.Web.Mvc;
using FoodManagementSystem.App_Start;

namespace FoodManagementSystem.Controllers
{
    [CustomException]
    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        ICuisineBL cuisineBL;
        public AdminController()
        {
            cuisineBL = new CuisineBL(); 
        }
        // GET: ViewCuisine
        public ActionResult ViewCuisine()
        {
            IEnumerable<Cuisine> cuisineDetails = cuisineBL.GetCuisine();
            return View(cuisineDetails);
        } 
        // GET: AddCuisine
        [HttpGet]
        public ActionResult AddCuisine()//Admin need to add the cuisine
        {
            return View();
        }
        //POST:AddCuisine
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult AddCuisine(CuisineViewModel cuisineViewModel)//Passing the cuisine to the BL layer  
        {
            if(ModelState.IsValid)
            {
                Cuisine cuisine = new Cuisine();
                cuisine.CuisineName = cuisineViewModel.CuisineName;
                cuisineBL.AddCuisine(cuisine); 
            }
            return View();
        }
    }
}