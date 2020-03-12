using FoodManagementSystem.BL;
using FoodManagementSystem.Entity;
using FoodManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodManagementSystem.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddFood()
        {
            FoodBL foodBL = new FoodBL();
            FoodViewModel foodViewModel = new FoodViewModel();
            ViewBag.FoodCategory = new SelectList(foodBL.GetFoodCategories(), "FoodCategoryID", "CategoryName");
            foodViewModel.RestaurantID = Convert.ToInt32(TempData["RestaurantID"].ToString());
            return View(foodViewModel);
        }
        [HttpPost]
        public ActionResult AddFood(FoodViewModel foodViewModel)
        {
            FoodBL foodBL = new FoodBL();
            if (ModelState.IsValid)
            {
                var foodItem = AutoMapper.Mapper.Map<FoodViewModel, FoodItem>(foodViewModel);
                
                foodBL.AddFood(foodItem);
            }
            ViewBag.FoodCategory = new SelectList(foodBL.GetFoodCategories(), "FoodCategoryID", "CategoryName");
            return View();
        }
    }
}