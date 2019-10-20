using StudentInformationApp.BLL;
using StudentInformationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformationApp.UI
{
    public partial class RegisterStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string regNo = inputRegNo.Value;
            string name = inputName.Value;
            string email = inputEmail.Value;
            string phone = inputPhone.Value;

            Student aStudent = new Student();
            aStudent.RegNo = regNo;
            aStudent.Name = name;
            aStudent.Email = email;
            aStudent.Phone = phone;

            StudentManager studentManager = new StudentManager();
            lblShow.InnerText = studentManager.SaveStudent(aStudent);
        }
    }
}