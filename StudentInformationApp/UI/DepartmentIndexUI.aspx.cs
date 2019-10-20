using StudentInformationApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformationApp.UI
{
    public partial class DepartmentIndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DepartmentManager departmentManager = new DepartmentManager();

            gridDepartments.DataSource = departmentManager.ShowDepartments();
            gridDepartments.DataBind();
        }
    }
}