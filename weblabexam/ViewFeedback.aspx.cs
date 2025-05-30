using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace weblabexam
{
    public partial class ViewFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
        }

        void LoadGrid()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Kainat_DB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFeedbackID.Text != "")
            {
                int id = Convert.ToInt32(txtFeedbackID.Text);
                Response.Redirect("EditFeedback.aspx?id=" + id);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFeedbackID.Text != "")
            {
                int id = Convert.ToInt32(txtFeedbackID.Text);
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Kainat_DB.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Table] WHERE FeedbackID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadGrid();
            }
        }
    }
}