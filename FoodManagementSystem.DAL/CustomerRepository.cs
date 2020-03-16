using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.DAL
{
    public class CustomerRepository
    {
        public bool GetSignUpDetails(Customer customerFields)
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
        public string GetLogInDetails(Customer customerFields)
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                Customer customer = dbContext.Customers.Where(c => c.Mail == customerFields.Mail && c.Password == customerFields.Password).SingleOrDefault();
            
                if(customer!=null)
                {
                    return customer.Role;
                }
                return "Not found";                
                
            }
           
        }
        public List<Customer> GetCustomerDetails()
        {
            using (FoodManagementSystemDBContext foodManagementDBContext = new FoodManagementSystemDBContext())
            {
                return foodManagementDBContext.Customers.ToList();
            }
        }
    }
}
