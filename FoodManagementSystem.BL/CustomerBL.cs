
using FoodManagementSystem.DAL;
using FoodManagementSystem.Entity;

namespace FoodManagementSystem.BL
{
    public class CustomerBL
    {
        CustomerRepository customerRepository = new CustomerRepository();
        public bool GetSignUpDetails(Customer customerFields)
        {
            return customerRepository.GetSignUpDetails(customerFields);
        }
        public string GetLogInDetails(Customer customerFields)
        {
            return customerRepository.GetLogInDetails(customerFields);
        }
    }
}

