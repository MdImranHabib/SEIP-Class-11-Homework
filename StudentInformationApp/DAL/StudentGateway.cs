using StudentInformationApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentInformationApp.DAL
{
    public class StudentGateway
    {
        public int AddStudent(Student aStudent)
        {
            string connectionString = @"Server=DESKTOP-DNG7DO1; Database=UniversityDB;Integrated Security=true";

            string query = "INSERT INTO Students Values('" + aStudent.RegNo + "','" + aStudent.Name + "','" +
                           aStudent.Email + "','" + aStudent.Phone + "')";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);


            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Student> GetStudents()
        {
            string connectionString = @"Server=DESKTOP-DNG7DO1; Database=UniversityDB;Integrated Security=true";

            string query = "SELECT * from Students";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Student> studentList = new List<Student>();

            while(reader.Read())
            {
                Student aStudent = new Student();
                aStudent.Id = Convert.ToInt32(reader["Id"]);
                aStudent.Name = reader["Name"].ToString();
                aStudent.RegNo = reader["RegNo"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Phone = reader["Phone"].ToString();

                studentList.Add(aStudent);
            }

            
            reader.Close();
            connection.Close();

            return studentList;
        }
    }
}