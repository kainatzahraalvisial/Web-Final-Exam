using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace weblabexam
{
	public partial class Stats : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            lbltotal_Submissions.Text = "Total Submissions: " + Application["total_Submissions"]; 
			lblLast_StudentName.Text = "Last Student Name: " + Session["Last_StudentName"];
        }
	}
}