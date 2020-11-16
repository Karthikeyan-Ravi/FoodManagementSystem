using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FoodManagementSystem.DAL
{
    public class CartRepository
    {
        string ShoppingCartId { get; set; }
        public const string CartSessionKey = "CartId";
        public static CartRepository GetCart(HttpContextBase context )
        {
            var cart = new CartRepository();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }
                
        public string GetCartId(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey] =
                        context.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class
                    Guid tempCartId = Guid.NewGuid();
                    // Send tempCartId back to client as a cookie
                    context.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return context.Session[CartSessionKey].ToString();
        }
        //public void AddToCart(FoodItem foodItem)
        //{
        //    using(FoodManagementSystemDBContext dBContext=new FoodManagementSystemDBContext())
        //    {
        //        dBContext.Carts
        //    }
        //}
    }
}
