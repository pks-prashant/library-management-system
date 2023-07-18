using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gail_lib
{
    public partial class adminbookissuing : System.Web.UI.Page
    {
        OracleConnection con = new OracleConnection(@"Data Source = orclpdb; User ID = video; Password=video1234;Unicode=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "INSERT INTO issue VALUES('" + TextBox2.Text.Trim() + "','" + TextBox1.Text.Trim() + "','" + TextBox3.Text.Trim() + "','" + TextBox4.Text.Trim() + "','" + TextBox5.Text.Trim() + "','" + TextBox6.Text.Trim() + "')";


                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();


                Response.Write("<script>alert('book issued Succesfully.');</script>");
                clearfrom();
                GridView1.DataBind();

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void clearfrom()
        {
            TextBox1.Text= null;
            TextBox2.Text= null;
            TextBox3.Text= null;
            TextBox4.Text= null;
            TextBox5.Text= null;
            TextBox6.Text= null;
        }
    }
}