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
    public class RestaurantRepository
    {
        FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext();
        public void AddRestaurant(RestaurantFields restaurantFields)
        {
            
            dbContext.Restaurant.Add(restaurantFields);
            dbContext.SaveChanges();
        }
        //SqlConnection sqlConnection;
        //string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        //public DataTable DisplayRestaurantDetails()
        //{
        //    //using (sqlConnection = new SqlConnection(connectionString))
        //    //{
        //    //    string query = "Sp_DisplayRestaurant";
        //    //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //    //    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //    //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    //    DataTable dataTable = new DataTable();
        //    //    sqlDataAdapter.Fill(dataTable);
        //    //    return dataTable;
        //    //}
        //}
        //public void UpdateRestaurantDetails(string name, string type, string location, int id)
        //{
        //    //string query = "Sp_UpdateRestaurant";
        //    //using (sqlConnection = new SqlConnection(connectionString))
        //    //{
        //    //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //    //    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //    //    sqlCommand.Parameters.AddWithValue("@RestaurantName", name);
        //    //    sqlCommand.Parameters.AddWithValue("@RestaurantType", type);
        //    //    sqlCommand.Parameters.AddWithValue("@Location", location);
        //    //    sqlCommand.Parameters.AddWithValue("@RestaurantId", id);
        //    //    sqlConnection.Open();
        //    //    sqlCommand.ExecuteNonQuery();
        //    //}
        //}
        //public void DeleteRestaurantDetails(int id)
        //{
        //    //using (sqlConnection = new SqlConnection(connectionString))
        //    //{
        //    //    string query = "Sp_DeleteRestaurant";
        //    //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //    //    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //    //    sqlCommand.Parameters.AddWithValue("@RestaurantId", id);
        //    //    sqlConnection.Open();
        //    //    sqlCommand.ExecuteNonQuery();

        //    //}
        //}
        //public void InsertRestaurantDetails(RestaurantFields restaurantFields)
        //{
        //    //string query = "Sp_InsertRestaurant";
        //    //using (sqlConnection = new SqlConnection(connectionString))
        //    //{
        //    //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //    //    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //    //    sqlCommand.Parameters.AddWithValue("@RestaurantName", restaurantFields.RestaurantName);
        //    //    sqlCommand.Parameters.AddWithValue("@RestaurantType", restaurantFields.RestaurantType);
        //    //    sqlCommand.Parameters.AddWithValue("@Location", restaurantFields.Location);
        //    //    sqlConnection.Open();
        //    //    sqlCommand.ExecuteNonQuery();
        //    //}
        //}
        public List<RestaurantFields> GetRestaurantDetails()
        {
            FoodManagementSystemDBContext foodManagementDBContext = new FoodManagementSystemDBContext();
            return foodManagementDBContext.Restaurant.ToList();
        }
        public RestaurantFields GetRestaurantId(int restaurantId)
        {
            return dbContext.Restaurant.ToList().Where(id => id.RestaurantID == restaurantId).SingleOrDefault();
        }
        public void UpdateRestaurant(RestaurantFields restaurantFields)
        {
            dbContext.Entry(restaurantFields).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void DeleteRestaurant(int id)
        {
            RestaurantFields restaurantFields = GetRestaurantId(id);
            dbContext.Restaurant.Attach(restaurantFields);
            dbContext.Restaurant.Remove(restaurantFields);
            dbContext.SaveChanges();
        }
    }
}