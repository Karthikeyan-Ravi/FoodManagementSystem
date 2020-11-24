using FoodManagementSystem.Entity;
using FoodManagementSystem.Models;

namespace FoodManagementSystem.App_Start
{
    public class Mapper             //Mapper class to automap entity & Viewmodel
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
                config.CreateMap<FoodItem, FoodViewModel>();
                config.CreateMap<Cuisine, CuisineViewModel>();
            });
        }
    }
}