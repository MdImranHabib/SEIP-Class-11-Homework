using StudentInformationApp.DAL;
using StudentInformationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformationApp.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway gateway = new DepartmentGateway();

        List<Department> departmentList = new List<Department>();

        public string SaveDepartment(Department aDepartment)
        {
            if (aDepartment.Code.Length > 3)
            {
                bool isDepartmentCodeExist = CheckDepartmentCode(aDepartment);

                if (isDepartmentCodeExist)
                {
                    return "This Code number is already exist! Please use another Code number";
                }
                else
                {
                    var rowAffected = gateway.AddDepartment(aDepartment);

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
                return "Invalid Department Code! it must be at least 4 characters.";
            }

        }

        public List<Department> ShowDepartments()
        {
            departmentList = gateway.GetDepartments();

            return departmentList;
        }

        private bool CheckDepartmentCode(Department aDepartment)
        {
            bool status = false;

            departmentList = gateway.GetDepartments();

            foreach (var department in departmentList)
            {
                if (department.Code.Contains(aDepartment.Code))
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