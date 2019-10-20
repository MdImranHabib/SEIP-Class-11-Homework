using StudentInformationApp.DAL;
using StudentInformationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformationApp.BLL
{
    public class CourseManager
    {
        CourseGateway gateway = new CourseGateway();

        List<Course> courseList = new List<Course>();

        public string SaveCourse(Course aCourse)
        {
            if (aCourse.Code.Length > 5)
            {
                bool isCourseCodeExist = CheckCourseCode(aCourse);

                if (isCourseCodeExist)
                {
                    return "This Course Code is already exist! Please use another Course Code";
                }
                else
                {
                    var rowAffected = gateway.AddCourse(aCourse);

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

        public List<Course> ShowCourses()
        {
            courseList = gateway.GetCourses();

            return courseList;
        }

        private bool CheckCourseCode(Course aCourse)
        {
            bool status = false;

            courseList = gateway.GetCourses();

            foreach (var course in courseList)
            {
                if (course.Code.Contains(aCourse.Code))
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