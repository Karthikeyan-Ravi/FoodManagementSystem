using FoodManagementSystem.DAL;
using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
