﻿using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FoodManagementSystem.DAL
{
    // interface declaration 
    public interface ICustomerRepository
    {
        // declaration of methods of 
        // interface that will be implemented  
        // by the class which inherits the interface 
        bool SignUpDetails(Customer customerFields);
        Customer GetLogInDetails(Customer customerFields);
        List<Customer> GetCustomerDetails();
        Customer GetCustomerByMailId(string mailId);
        void AddToCart(Cart cart);
        IEnumerable<Cart> GetCartItems(int id);
        void DeleteCartItem(int cartId);
    }
    public class CustomerRepository: ICustomerRepository     //Implementing the interfce
    {
        public bool SignUpDetails(Customer customerFields)   //Add  the customer details to db   
        {

            try
            {
                using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
                {
                    //SqlParameter name = new SqlParameter("@FullName", customerFields.FullName);
                    //SqlParameter gender = new SqlParameter("@Gender", customerFields.Gender);
                    //SqlParameter phone = new SqlParameter("@PhoneNumber", customerFields.PhoneNumber);
                    //SqlParameter mail = new SqlParameter("@Mail", customerFields.Mail);
                    //SqlParameter password = new SqlParameter("@Password", customerFields.Password);
                    //SqlParameter role = new SqlParameter("@Role", customerFields.Role);
                    //int result = dbContext.Database.ExecuteSqlCommand("sp_InsertCustomer @FullName,@PhoneNumber,@Gender,@Mail,@Password,@Role", name, phone, gender, mail, password, role);

                    dbContext.Customers.Add(customerFields);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Customer GetLogInDetails(Customer customerFields)    //Check the login details
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                Customer customer = dbContext.Customers.Where(c => c.Mail == customerFields.Mail && c.Password == customerFields.Password).SingleOrDefault();
                return customer;
            }
           
        }
        public List<Customer> GetCustomerDetails()      //Retrieve the customer details 
        {
            using (FoodManagementSystemDBContext foodManagementDBContext = new FoodManagementSystemDBContext())
            {
                return foodManagementDBContext.Customers.ToList();
            }
        }
        public Customer GetCustomerByMailId(string mailId)
        {
            using (FoodManagementSystemDBContext foodManagementDBContext = new FoodManagementSystemDBContext())
            {
                return foodManagementDBContext.Customers.Where(m => m.Mail == mailId).FirstOrDefault();
            }
        }
        public void AddToCart(Cart cart)
        {
            using (FoodManagementSystemDBContext foodManagementDBContext = new FoodManagementSystemDBContext())
            {
                foodManagementDBContext.Carts.Add(cart);
                foodManagementDBContext.SaveChanges();
            }
        }
        public IEnumerable<Cart> GetCartItems(int id)
        {
            using(FoodManagementSystemDBContext foodManagementSystemDBContext=new FoodManagementSystemDBContext())
            {
                return foodManagementSystemDBContext.Carts.Include("FoodItem").Include("Customer").Where(u => u.UserId == id).ToList();
            }
        }
       public void DeleteCartItem(int cartId)
        {
            using (FoodManagementSystemDBContext foodManagementSystemDBContext = new FoodManagementSystemDBContext())
            {

                Cart cart = foodManagementSystemDBContext.Carts.Find(cartId);
                foodManagementSystemDBContext.Carts.Remove(cart);
                foodManagementSystemDBContext.SaveChanges();
            }
        }
    }
}
