using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqDeom1
{
    public partial class Demo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinqDemoDataContext dataContext = new LinqDemoDataContext();
            //This is the LinqQuery to reterive the Data From the Underlying DataBase(Sql Server) after the Conversion by the Linq Provider
            GridView.DataSource = from student in dataContext.Students
                                  where student.Gender == "FeMale"
                                  select student;

            //int[] numbers = {2,5,8,9,7,5,6,4,2,3,6,4,5};
            //GridView.DataSource = from number in numbers
            //                      where (number % 2) == 0
            //                      select number;
            GridView.DataBind();
        }
    }
}