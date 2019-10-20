using StudentInformationApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformationApp.UI
{
    public partial class StudentIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentManager studentManager = new StudentManager();

            gridStudents.DataSource = studentManager.ShowStudents();
            gridStudents.DataBind();
        }
    }
}