using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodManagementSystem.Models
{
    public class Mapper
    {
        public static void Mapping()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<UserSignUpViewModel, CustomerFields>();
                config.CreateMap<UserSignInViewModel, CustomerFields>();
                config.CreateMap<RestaurantViewModel, RestaurantFields>();
                //config.CreateMap<RestaurantFields, RestaurantViewModel>();
            });
        } 
    }
}