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
    public partial class userlogin : System.Web.UI.Page
    {
        OracleConnection con = new OracleConnection(@"Data Source=orclpdb;User ID=video;Password=video1234;Unicode=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Lb1.Visible = false;
            
        }

        protected void login_button(object sender, EventArgs e)
        {
            try
            {
                if(con.State==ConnectionState.Closed)
                    con.Open();

                OracleCommand com = new OracleCommand("SELECT * FROM users WHERE userid='" + TextBox1.Text.Trim()+ "' AND password='" + TextBox2.Text.Trim()+ "'", con);

                OracleDataReader odr = com.ExecuteReader();
                if (odr.HasRows)
                {
                    while (odr.Read())
                    {
                        // Response.Write("<script>alert('HELLO " + odr.GetValue(0).ToString() + "')</script>");
                        Session["name"] = odr.GetValue(0).ToString();
                        Session["role"] = "user";
                        Session["usedid"]= odr.GetValue(8).ToString();
                        Session["status"]=odr.GetValue(10).ToString();
                    }
                    Response.Redirect("default.aspx");
                }
                else
                    Lb1.Visible = true;


            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" +ex.Message + "')</script>");
            }
        }
    }
}