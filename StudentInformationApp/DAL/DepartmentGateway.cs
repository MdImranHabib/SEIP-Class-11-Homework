using StudentInformationApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentInformationApp.DAL
{
    public class DepartmentGateway
    {
        public int AddDepartment(Department aDepartment)
        {
            string connectionString = @"Server=DESKTOP-DNG7DO1; Database=UniversityDB;Integrated Security=true";

            string query = "INSERT INTO Departments Values('" + aDepartment.Name + "','" + aDepartment.Code + "')";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);


            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Department> GetDepartments()
        {
            string connectionString = @"Server=DESKTOP-DNG7DO1; Database=UniversityDB;Integrated Security=true";

            string query = "SELECT * from Departments";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Department> departmentList = new List<Department>();

            while (reader.Read())
            {
                Department aDepartment = new Department();
                aDepartment.Id = Convert.ToInt32(reader["Id"]);
                aDepartment.Name = reader["Name"].ToString();
                aDepartment.Code = reader["Code"].ToString();

                departmentList.Add(aDepartment);
            }


            reader.Close();
            connection.Close();

            return departmentList;
        }
    }
}