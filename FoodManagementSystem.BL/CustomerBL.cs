using FoodManagementSystem.DAL;
using FoodManagementSystem.Entity;
using System.Collections;
using System.Collections.Generic;

namespace FoodManagementSystem.BL
{
    // interface declaration 
    public interface ICustomerBL
    {
        // declaration of methods of 
        // interface that will be implemented  
        // by the class which inherits the interface 
        bool SignUpDetails(Customer customerFields);
        Customer GetLogInDetails(Customer customerFields);
        Customer GetCustomerByMailId(string mailId);
        void AddToCart(Cart cart);
        IEnumerable<Cart> GetCartItems(int id);
        void DeleteCartItem(int cartId);
    }
    public class CustomerBL: ICustomerBL          //Implementing the interfce
    {
        //creating an Reference of interface
        ICustomerRepository customerRepository;
        public CustomerBL()
        {
            // Declare an interface instance
            customerRepository = new CustomerRepository();
        }
        public bool SignUpDetails(Customer customerFields)   //Add  the customer details to db   
        {           
            return customerRepository.SignUpDetails(customerFields);
        }
        public Customer GetLogInDetails(Customer customerFields)    //Check the login details
        {
            return customerRepository.GetLogInDetails(customerFields);
        }
        public Customer GetCustomerByMailId(string mailId)
        {
            return customerRepository.GetCustomerByMailId(mailId);
        }
        public void AddToCart(Cart cart)
        {
            customerRepository.AddToCart(cart);
        }
        public IEnumerable<Cart> GetCartItems(int id)
        {
            return customerRepository.GetCartItems(id);
        }
        public void DeleteCartItem(int cartId)
        {
            customerRepository.DeleteCartItem(cartId);
        }
    }
}
