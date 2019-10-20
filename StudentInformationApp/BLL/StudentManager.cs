using StudentInformationApp.DAL;
using StudentInformationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformationApp.BLL
{
    public class StudentManager
    {
        StudentGateway gateway = new StudentGateway();

        List<Student> studentList = new List<Student>();

        public string SaveStudent(Student aStudent)
        {
            if(aStudent.RegNo.Length > 5)
            {
                bool isRegNoExist = CheckRegNo(aStudent);

                if(isRegNoExist)
                {
                    return "This Reg. No. is already exist! Please use another Reg. No.";
                }
                else
                {
                    var rowAffected = gateway.AddStudent(aStudent);

                    if (rowAffected > 0)
                    {
                        return "Saved Successfully!";
                    }
                    else
                    {
                        return "Save Failed!";
                    }
                }

            }
            else
            {
                return "Invalid Reg. No.! it must be at least 6 characters.";
            }
            
        }

        public List<Student> ShowStudents()
        {
            studentList = gateway.GetStudents();

            return studentList;
        }

        private bool CheckRegNo(Student aStudent)
        {
            bool status = false;

            studentList = gateway.GetStudents();

            foreach(var student in studentList)
            {
                if(student.RegNo.Contains(aStudent.RegNo))
                {
                    status = true;
                    break;
                }
                else
                {
                    status = false;
                }
            }

            return status;
        }
    }
}