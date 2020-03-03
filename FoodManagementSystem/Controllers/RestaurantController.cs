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
        RestaurantFields restaurantFields = new RestaurantFields();
        // GET: Restaurant
        public ActionResult Index()
        {
            IEnumerable<RestaurantFields> restaurantDetails = restaurantBL.GetRestaurantDetails();
            ViewBag.RestaurantDetails = restaurantDetails;
            return View();
        }
        public ActionResult AddRestaurant()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddRestaurant(RestaurantViewModel restaurantViewModel)
        {
            if (ModelState.IsValid)
            {
                var restaurantFields = AutoMapper.Mapper.Map<RestaurantViewModel, RestaurantFields>(restaurantViewModel);
                restaurantBL.AddtRestaurant(restaurantFields);
                Response.Write("Redtaurant added successfully");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            RestaurantViewModel restaurantViewModel = new RestaurantViewModel();
            restaurantFields =restaurantBL.GetRestaurantId(id);
            //var restaurantViewModel = AutoMapper.Mapper.Map<RestaurantFields, RestaurantViewModel>(restaurantFields);
            restaurantViewModel = new RestaurantViewModel();

            restaurantViewModel.RestaurantID = restaurantFields.RestaurantID;
            restaurantViewModel.RestaurantName = restaurantFields.RestaurantName;
            restaurantViewModel.RestaurantType = restaurantFields.RestaurantType;
            restaurantViewModel.Location = restaurantFields.Location;
            return View(restaurantViewModel);
            
        }
        public ActionResult Update(RestaurantViewModel restaurantViewModel)
        {
            if(ModelState.IsValid)
            {
                var restaurantFields = AutoMapper.Mapper.Map<RestaurantViewModel, RestaurantFields>(restaurantViewModel);
                //restaurantFields.RestaurantID = restaurantViewModel.RestaurantID;
                //restaurantFields.RestaurantName = restaurantViewModel.RestaurantName;
                //restaurantFields.RestaurantType = restaurantViewModel.RestaurantType;
                //restaurantFields.Location = restaurantViewModel.Location;
                restaurantBL.UpdateRestaurant(restaurantFields);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            restaurantFields=restaurantBL.GetRestaurantId(id);
            RestaurantViewModel restaurantViewModel = new RestaurantViewModel();
            if(ModelState.IsValid)
            {
                restaurantViewModel.RestaurantID = restaurantFields.RestaurantID;
                restaurantViewModel.RestaurantName = restaurantFields.RestaurantName;
                restaurantViewModel.RestaurantType = restaurantFields.RestaurantType;
                restaurantViewModel.Location = restaurantFields.Location;
                return View(restaurantViewModel);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(RestaurantViewModel restaurantViewModel)
        {
            restaurantFields.RestaurantID = restaurantViewModel.RestaurantID;
            restaurantFields.RestaurantName = restaurantViewModel.RestaurantName;
            restaurantFields.RestaurantType = restaurantViewModel.RestaurantType;
            restaurantFields.Location = restaurantViewModel.Location;
            restaurantBL.DeleteRestaurant(restaurantFields);
            return RedirectToAction("Index");
        }
   }

}
