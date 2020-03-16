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
    public class RestaurantController : Controller
    {
        RestaurantBL restaurantBL = new RestaurantBL();
        Restaurant restaurantFields = new Restaurant();
        // GET: Restaurant
        public ActionResult Index()
        {
            IEnumerable<Restaurant> restaurantlList;
            List<RestaurantViewModel> restaurantViewModelList=new List<RestaurantViewModel>();
            restaurantlList = restaurantBL.GetRestaurantDetails();
            //var restaurantViewModelList = AutoMapper.Mapper.Map<Restaurant, RestaurantViewModel>(restaurantlList);
            foreach (Restaurant restaurant in restaurantlList)
            {
                var details = AutoMapper.Mapper.Map<Restaurant, RestaurantViewModel>(restaurant);
                restaurantViewModelList.Add(details);
            }
            //ViewBag.RestaurantDetails = restaurantDetails;
            return View(restaurantViewModelList);
        }
        public ActionResult AddRestaurant()
        {
            CuisineBL cuisineBL = new CuisineBL();
            ViewBag.CuisineDetails = new SelectList(cuisineBL.GetCuisine(), "CuisineID", "CuisineName");
            return View();
        }
        [HttpPost]
        public ActionResult AddRestaurant(RestaurantViewModel restaurantViewModel)
        {
           
            if (ModelState.IsValid)
            {
                CuisineBL cuisineBL = new CuisineBL();
                ViewBag.CuisineDetails = new SelectList(cuisineBL.GetCuisine(), "CuisineID", "CuisineName");
                Restaurant restaurant = AutoMapper.Mapper.Map<RestaurantViewModel, Restaurant>(restaurantViewModel);
                //    restaurant.RestaurantCuisines = new List<RestaurantCuisine>();
                //    foreach (int detail in restaurantViewModel.restaurantCuisine)
                //    {
                //        RestaurantCuisine restaurantCuisine = new RestaurantCuisine();
                //        restaurantCuisine.CuisineID = detail;
                //        restaurant.RestaurantCuisines.Add(restaurantCuisine);
                //    }

                restaurantBL.AddtRestaurant(restaurant);
                //TempData["RestaurantID"] = restaurant.RestaurantID;
                return RedirectToAction("AddFood", "Food");
                //}
            }
       
            return View();
        }
        public ActionResult Edit(int id)
        {

            restaurantFields = restaurantBL.GetRestaurantId(id);
            var restaurantViewModel = AutoMapper.Mapper.Map<Restaurant, RestaurantViewModel>(restaurantFields);

            return View(restaurantViewModel);

        }
        public ActionResult Update(RestaurantViewModel restaurantViewModel)
        {
            if (ModelState.IsValid)
            {
                var restaurantFields = AutoMapper.Mapper.Map<RestaurantViewModel, Restaurant>(restaurantViewModel);

                restaurantBL.UpdateRestaurant(restaurantFields);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            restaurantFields = restaurantBL.GetRestaurantId(id);
            var restaurantViewModel = AutoMapper.Mapper.Map<Restaurant, RestaurantViewModel>(restaurantFields);
            //estaurantViewModel restaurantViewModel = new RestaurantViewModel();
            if (ModelState.IsValid)
            {

                return View(restaurantViewModel);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(RestaurantViewModel restaurantViewModel)
        {
            var restaurantFields = AutoMapper.Mapper.Map<RestaurantViewModel, Restaurant>(restaurantViewModel);
            restaurantBL.DeleteRestaurant(restaurantFields);
            return RedirectToAction("Index");
        }
        //[HttpGet]
        //public ActionResult AddFood()
        //{
        //    ViewBag.RestaurantFields = new SelectList(restaurantBL.GetRestaurantDetails(), "RestaurantID", "RestaurantName");
        //    return View();
        //}
        //FoodBL foodBL = new FoodBL();
        //FoodItem foodItem = new FoodItem();
        //[HttpPost]
        //public ActionResult AddFood(FoodViewModel foodViewModel)
        //{
        //    ViewBag.RestaurantFields = new SelectList(restaurantBL.GetRestaurantDetails(), "RestaurantID", "RestaurantName");
        //    var foodItem = AutoMapper.Mapper.Map<FoodViewModel, FoodItem>(foodViewModel);
        //    foodBL.AddFood(foodItem);
        //    return View();
        //}
    }

}
