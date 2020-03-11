﻿using FoodManagementSystem.Entity;
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
            IEnumerable<Restaurant> restaurantDetails = restaurantBL.GetRestaurantDetails();
            ViewBag.RestaurantDetails = restaurantDetails;
            return View();
        }
        public ActionResult AddRestaurant()
        {
            CuisineBL cuisineBL = new CuisineBL();
            ViewBag.restaurantCuisine = new SelectList(cuisineBL.GetCuisine(), "CuisineID", "CuisineName");
            return View();
        }
        [HttpPost]
        public ActionResult AddRestaurant(RestaurantViewModel restaurantViewModel)
        {
            CuisineBL cuisineBL = new CuisineBL();
            if (ModelState.IsValid)
            {
                Restaurant restaurant = AutoMapper.Mapper.Map<RestaurantViewModel, Restaurant>(restaurantViewModel);
                restaurant.RestaurantCuisines = new List<RestaurantCuisine>();
                foreach (int detail in restaurantViewModel.restaurantCuisine)
                {
                    RestaurantCuisine restaurantCuisine = new RestaurantCuisine();
                    restaurantCuisine.CuisineID = detail;
                    restaurant.RestaurantCuisines.Add(restaurantCuisine);
                }
                restaurantBL.AddtRestaurant(restaurant);
            }
            ViewBag.restaurantCuisine = new SelectList(cuisineBL.GetCuisine(), "CuisineID", "CuisineName");
            return View(restaurantViewModel);
        }
        public ActionResult Edit(int id)
        {
            //RestaurantViewModel restaurantViewModel = new RestaurantViewModel();
            restaurantFields =restaurantBL.GetRestaurantId(id);
            var restaurantViewModel = AutoMapper.Mapper.Map<Restaurant, RestaurantViewModel>(restaurantFields);
            //restaurantViewModel = new RestaurantViewModel();

            //restaurantViewModel.RestaurantID = restaurantFields.RestaurantID;
            //restaurantViewModel.RestaurantName = restaurantFields.RestaurantName;
            //restaurantViewModel.Cuisine = restaurantFields.Cuisine;
            //restaurantViewModel.Location = restaurantFields.Location;
            return View(restaurantViewModel);
            
        }
        public ActionResult Update(RestaurantViewModel restaurantViewModel)
        {
            if(ModelState.IsValid)
            {
                var restaurantFields = AutoMapper.Mapper.Map<RestaurantViewModel, Restaurant>(restaurantViewModel);
                //restaurantFields.RestaurantID = restaurantViewModel.RestaurantID;
                //restaurantFields.RestaurantName = restaurantViewModel.RestaurantName;
                //restaurantFields.Cuisine = restaurantViewModel.Cuisine;
                //restaurantFields.Location = restaurantViewModel.Location;
                restaurantBL.UpdateRestaurant(restaurantFields);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            restaurantFields=restaurantBL.GetRestaurantId(id);
            var restaurantViewModel = AutoMapper.Mapper.Map<Restaurant, RestaurantViewModel>(restaurantFields);
            //estaurantViewModel restaurantViewModel = new RestaurantViewModel();
            if(ModelState.IsValid)
            {
                //restaurantViewModel.RestaurantID = restaurantFields.RestaurantID;
                //restaurantViewModel.RestaurantName = restaurantFields.RestaurantName;
                //restaurantViewModel.Cuisine = restaurantFields.Cuisine;
                //restaurantViewModel.Location = restaurantFields.Location;
                return View(restaurantViewModel);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(RestaurantViewModel restaurantViewModel)
        {
            var restaurantFields = AutoMapper.Mapper.Map<RestaurantViewModel, Restaurant>(restaurantViewModel);
            //restaurantFields.RestaurantID = restaurantViewModel.RestaurantID;
            //restaurantFields.RestaurantName = restaurantViewModel.RestaurantName;
            //restaurantFields.Cuisine = restaurantViewModel.Cuisine;
            //restaurantFields.Location = restaurantViewModel.Location;
            restaurantBL.DeleteRestaurant(restaurantFields);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddFood()
        {
            ViewBag.RestaurantFields = new SelectList(restaurantBL.GetRestaurantDetails(), "RestaurantID", "RestaurantName");
            return View();
        }
        FoodBL foodBL = new FoodBL();
        FoodItem foodItem = new FoodItem();
        [HttpPost]
        public ActionResult AddFood(FoodViewModel foodViewModel)
        {
            ViewBag.RestaurantFields = new SelectList(restaurantBL.GetRestaurantDetails(), "RestaurantID", "RestaurantName");
            var foodItem = AutoMapper.Mapper.Map<FoodViewModel, FoodItem>(foodViewModel);
            foodBL.AddFood(foodItem);
            return View();
        }
   }

}