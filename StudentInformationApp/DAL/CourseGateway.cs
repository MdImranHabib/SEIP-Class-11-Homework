using StudentInformationApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentInformationApp.DAL
{
    public class CourseGateway
    {
        public int AddCourse(Course aCourse)
        {
            string connectionString = @"Server=DESKTOP-DNG7DO1; Database=UniversityDB;Integrated Security=true";

            string query = "INSERT INTO Courses Values('" + aCourse.Name + "','" + aCourse.Code + "','" + aCourse.Credit + "')";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);


            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Course> GetCourses()
        {
            string connectionString = @"Server=DESKTOP-DNG7DO1; Database=UniversityDB;Integrated Security=true";

            string query = "SELECT * from Courses";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Course> courseList = new List<Course>();

            while (reader.Read())
            {
                Course aCourse = new Course();
                aCourse.Id = Convert.ToInt32(reader["Id"]);
                aCourse.Name = reader["Name"].ToString();
                aCourse.Code = reader["Code"].ToString();
                aCourse.Credit = Convert.ToInt32(reader["Credit"]);

                courseList.Add(aCourse);
            }


            reader.Close();
            connection.Close();

            return courseList;
        }
    }
}