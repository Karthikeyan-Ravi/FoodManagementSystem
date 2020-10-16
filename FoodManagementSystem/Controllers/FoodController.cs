using FoodManagementSystem.BL;
using FoodManagementSystem.Entity;
using FoodManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace FoodManagementSystem.Controllers
{
    public class FoodController : Controller
    {
        //creating an Reference of interface
        IFoodBL foodBL;
        public FoodController()
        {
            // Declare an interface instance
            foodBL = new FoodBL();
        }
        // GET: Food
        public ActionResult Index()//For admin purpose to display all the foods 
        {
            IEnumerable<FoodItem> foodDetailsList;
            foodDetailsList = foodBL.GetFoodDetails();//Get all the foods available in the restaurants
            return View(foodDetailsList);
        }
        public ActionResult DisplayRestaurantFoods(int? id)//For admin purpose to display foods of particular restaurant
        {
            IEnumerable<FoodItem> restaurantFoods; 
            if(id!= null)           //If restaurant id not equal to null the tempdata is updated with the new restaurant id
                TempData["RestaurantID"] = id;
            if (TempData["RestaurantID"] != null)   //If restaurant id equals to null, tempdata contains the value from previous view
            {
                restaurantFoods = foodBL.DisplayRestaurantFoods((int)TempData["RestaurantID"]);
                if (restaurantFoods.Count() != 0)
                {
                    ViewBag.restaurantFoods = restaurantFoods;
                    return View();

                }
                return RedirectToAction("AddFood");
            }
            return RedirectToAction("AddFood");
        }
        //GET : AddFood
        public ActionResult AddFood()       //Add food to the particular restaurant
        {
            //FoodBL foodBL = new FoodBL();
            FoodViewModel foodViewModel = new FoodViewModel();
            ViewBag.FoodCategory = new SelectList(foodBL.GetFoodCategories(), "FoodCategoryID", "CategoryName");
            foodViewModel.RestaurantID = Convert.ToInt32(TempData["RestaurantID"].ToString());
            return View(foodViewModel);
        }
        //POST: : AddFood
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult AddFood(FoodViewModel foodViewModel)        //Add food to the particular restaurant
        {
            //FoodBL foodBL = new FoodBL();
            if (ModelState.IsValid)
            {
                string fileName = Path.GetFileNameWithoutExtension(foodViewModel.ImageUpload.FileName);
                string extension = Path.GetExtension(foodViewModel.ImageUpload.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                foodViewModel.FoodImagePath = fileName;
                FoodManagementSystem.Entity.FoodItem foodItem = AutoMapper.Mapper.Map<FoodViewModel, FoodItem>(foodViewModel);
                fileName=Path.Combine(Server.MapPath("~/FoodImages/"),fileName);
                foodViewModel.ImageUpload.SaveAs(fileName);
                foodBL.AddFood(foodItem);
                if (foodItem != null)
                    Response.Write("Food added successfully");
                else
                    return View();
            }
            ViewBag.FoodCategory = new SelectList(foodBL.GetFoodCategories(), "FoodCategoryID", "CategoryName");
            return View();
        }
        //GET:EditFood
        public ActionResult EditFood(int id)    //Edit the food details
        {
            FoodItem foodItem = foodBL.GetFoodDetailsById(id);
           // FoodManagementSystem.Models.FoodViewModel foodViewModel = AutoMapper.Mapper.Map<FoodItem, FoodViewModel>(foodItem);
            ViewBag.FoodCategory = new SelectList(foodBL.GetFoodCategories(), "FoodCategoryID", "CategoryName");
            return View(foodItem);
        }
        [ValidateAntiForgeryToken]
        //POST:UpdateFood
        public ActionResult UpdateFood(FoodViewModel foodViewModel) //Update the food details
        {
            if(ModelState.IsValid)
            {
                string fileName = Path.GetFileNameWithoutExtension(foodViewModel.ImageUpload.FileName);
                string extension = Path.GetExtension(foodViewModel.ImageUpload.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                foodViewModel.FoodImagePath = fileName;
                FoodManagementSystem.Entity.FoodItem foodItem = AutoMapper.Mapper.Map<FoodViewModel, FoodItem>(foodViewModel);
                fileName = Path.Combine(Server.MapPath("~/FoodImages/"), fileName);
                foodViewModel.ImageUpload.SaveAs(fileName);
               // var foodItem = AutoMapper.Mapper.Map<FoodViewModel, FoodItem>(foodViewModel);
                foodBL.UpdateFood(foodItem);
                return RedirectToAction("DisplayRestaurantFoods",new { id = foodItem.RestaurantID });
            }
            ViewBag.FoodCategory = new SelectList(foodBL.GetFoodCategories(), "FoodCategoryID", "CategoryName");
            return View(); 
        }
        //GET:DeleteFood
        public ActionResult DeleteFood(int id,int restaurantId)//Delete particular food in the restaurant
        {
            foodBL.DeleteFood(id);
            return RedirectToAction("DisplayRestaurantFoods", new { id = restaurantId });
        }
    }
}