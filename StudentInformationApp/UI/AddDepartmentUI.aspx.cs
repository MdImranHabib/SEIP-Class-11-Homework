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
    public partial class AddDepartmentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string departmentName = inputName.Value;
            string departmentCode = inputCode.Value;

            Department aDepartment = new Department();
            aDepartment.Name = departmentName;
            aDepartment.Code = departmentCode;

            DepartmentManager departmentManager = new DepartmentManager();
            lblShow.InnerText = departmentManager.SaveDepartment(aDepartment);

        }
    }
}