using FoodManagementSystem.Entity;
using FoodManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodManagementSystem.App_Start
{
    public class Mapper
    {
        public static void Mapping()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<UserSignUpViewModel, Customer>();
                config.CreateMap<UserSignInViewModel, Customer>();
                config.CreateMap<RestaurantViewModel, Restaurant>();
                config.CreateMap<Restaurant, RestaurantViewModel>(); 
                config.CreateMap<FoodViewModel,FoodItem>();
            });
        }
    }
}