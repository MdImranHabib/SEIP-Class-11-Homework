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
    public partial class AddCourseUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = inputName.Value;
            string code = inputCode.Value;
            int credit = Convert.ToInt32(inputCredit.Value);

            Course aCourse = new Course();
            aCourse.Name = name;
            aCourse.Code = code;
            aCourse.Credit = credit;

            CourseManager courseManager = new CourseManager();
            lblShow.InnerText = courseManager.SaveCourse(aCourse);
        }
    }
}