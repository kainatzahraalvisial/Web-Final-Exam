using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace weblabexam
{
	public partial class AddFeedback : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                if (Session["Last_StudentName"] != null)
                {
                    SNametxt.Text = Session["Last_StudentName"].ToString();
                }
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Kainat_DB.mdf;Integrated Security=True");

            
             con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [Table] (StudentName, CourseName, Comments, Phone) VALUES (@StudentName, @CourseName, @Comments, @Phone)", con);
                cmd.Parameters.AddWithValue("@StudentName", SNametxt.Text);
                cmd.Parameters.AddWithValue("@CourseName", CNametxt.Text);
                cmd.Parameters.AddWithValue("@Comments", Commenttxt.Text);
                cmd.Parameters.AddWithValue("@Phone", Phonetxt.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                Application["totalSubmissions"] = (int?)Application["totalSubmissions"] + 1 ?? 1;
                Session["LastStudentName"] = SNametxt.Text;
                 
            }
        }

       
    }
}