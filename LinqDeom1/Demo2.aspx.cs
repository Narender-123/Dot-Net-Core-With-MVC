using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqDeom1
{
    public partial class Demo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Linq Expression
            IEnumerable<Student1> students = Student1.GetAllStudents().Where(student => student.Gender == "Male");

            //Linq Query Using Sql Like Structure----------------------------------------------------------------------------
            //IEnumerable<Student1> students = from student in Student1.GetAllStudents()
            //where student.Gender == "Male"
            //select student;
            GridView1.DataSource = students;
            GridView1.DataBind();
        }
    }
}