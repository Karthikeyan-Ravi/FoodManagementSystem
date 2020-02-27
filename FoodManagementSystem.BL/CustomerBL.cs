
using FoodManagementSystem.DAL;
using FoodManagementSystem.Entity;

namespace FoodManagementSystem.BL
{
    public class CustomerBL
    {
        CustomerRepository customerRepository = new CustomerRepository();
        public bool GetSignUpDetails(CustomerFields customerFields)
        {
            return customerRepository.GetSignUpDetails(customerFields);
        }
        public string GetLogInDetails(string mail, string password)
        {
            return customerRepository.GetLogInDetails(mail, password);
        }
    }
}

