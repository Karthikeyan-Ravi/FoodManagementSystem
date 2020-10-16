using FoodManagementSystem.Entity;
using FoodManagementSystem.Models;
using FoodManagementSystem.BL;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FoodManagementSystem.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RestaurantController : Controller
    {
        //creating an Reference of interface
        IResturant restaurantBL;
        ICuisineBL cuisineBL;
        public RestaurantController()
        {
            // Declare an interface instance
            restaurantBL = new RestaurantBL();
            cuisineBL = new CuisineBL();
        }
        Restaurant restaurantFields = new Restaurant();
        // GET: Restaurant
        public ActionResult Index()//For admin purpose to display all the restaurants 
        {
            // throw new System.Exception();
            IEnumerable<Restaurant> restaurantlList;
            restaurantlList = restaurantBL.GetRestaurantDetails();
            return View(restaurantlList);
        }
        // GET: AddRestaurant
        public ActionResult AddRestaurant()//Add new restaurant
        {
            //Retrives all the cuisine details from the database
            ViewBag.CuisineDetails = new SelectList(cuisineBL.GetCuisine(), "CuisineID", "CuisineName");
            return View();
        }
        [ValidateAntiForgeryToken]
        // POST: AddRestaurant
        [HttpPost]
        public ActionResult AddRestaurant(RestaurantViewModel restaurantViewModel)
        {
           
            if (ModelState.IsValid)
            {
                Restaurant restaurant = AutoMapper.Mapper.Map<RestaurantViewModel, Restaurant>(restaurantViewModel);
                restaurantBL.AddRestaurant(restaurant);
                TempData["RestaurantID"] = restaurant.RestaurantID;
                return RedirectToAction("AddFood", "Food");
             }
            ViewBag.CuisineDetails = new SelectList(cuisineBL.GetCuisine(), "CuisineID", "CuisineName");
            return View();
        }
        // GET: EditRestaurant
        public ActionResult Edit(int id)//Edit the restaurant details
        {
            ViewBag.CuisineDetails = new SelectList(cuisineBL.GetCuisine(), "CuisineID", "CuisineName");
            restaurantFields = restaurantBL.GetRestaurantId(id);
            var restaurantViewModel = AutoMapper.Mapper.Map<Restaurant, RestaurantViewModel>(restaurantFields);
            return View(restaurantViewModel);

        }
        [ValidateAntiForgeryToken]
        // POST: UpdateRestaurant
        public ActionResult Update(RestaurantViewModel restaurantViewModel)//Update the details to the database
        {
            if (ModelState.IsValid)
            {
                var restaurantFields = AutoMapper.Mapper.Map<RestaurantViewModel, Restaurant>(restaurantViewModel);
                restaurantBL.UpdateRestaurant(restaurantFields);
                return RedirectToAction("Index");
            }
            ViewBag.CuisineDetails = new SelectList(cuisineBL.GetCuisine(), "CuisineID", "CuisineName");
            return View();
        }
        // GET: DeleteRestaurant
        public ActionResult Delete(int id)//Delete the restaurant from the database 
        {
            restaurantBL.DeleteRestaurant(id);
            return RedirectToAction("Index");
        }
    }

}
