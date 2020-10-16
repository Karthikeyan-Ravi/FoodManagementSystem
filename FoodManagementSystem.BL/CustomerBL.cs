using FoodManagementSystem.DAL;
using FoodManagementSystem.Entity;

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
    }
}

