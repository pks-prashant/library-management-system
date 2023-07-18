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
    public partial class adminmembermanagement : System.Web.UI.Page
    {
        OracleConnection con = new OracleConnection(@"Data Source = orclpdb; User ID = video; Password=video1234;Unicode=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            clearfrom();
        }
        //delete button
        protected void Button2_Click(object sender, EventArgs e)
        {
             
            try
            {
                con.Open();

                


                OracleCommand cmd = new OracleCommand("DELETE FROM users WHERE userid='" + TextBox1.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();


                Response.Write("<script>alert('user daleted Succesfully.');</script>");
                clearfrom();
                GridView1.DataBind();

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Go_Click(object sender, EventArgs e)
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OracleCommand cmd = new OracleCommand("SELECT * from users where userid='" + TextBox1.Text.Trim() + "'", con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][0].ToString();
                    TextBox7.Text = dt.Rows[0][10].ToString();
                    TextBox8.Text = dt.Rows[0][1].ToString();
                    TextBox3.Text = dt.Rows[0][2].ToString();
                    TextBox4.Text = dt.Rows[0][3].ToString();
                    TextBox9.Text = dt.Rows[0][4].ToString();
                    TextBox10.Text = dt.Rows[0][5].ToString();
                    TextBox11.Text = dt.Rows[0][6].ToString();
                    TextBox6.Text = dt.Rows[0][7].ToString();
                    
                    


                }
                else
                {
                    Response.Write("<script>alert('Publisher with this ID does not exist.');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }
        void clearfrom()
        {
            TextBox2.Text = null;
            TextBox7.Text = null;
            TextBox8.Text = null;
            TextBox3.Text = null;
            TextBox4.Text = null;
            TextBox9.Text = null;
            TextBox10.Text = null;
            TextBox11.Text = null;
            TextBox6.Text = null;
        }

        protected void act_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();




                OracleCommand cmd = new OracleCommand("UPDATE users SET acc_status='Active' WHERE userid='" + TextBox1.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();


                Response.Write("<script>alert('" + TextBox1.Text.Trim() + "`s Account Status Updated Succesfully.');</script>");
                clearfrom();
                GridView1.DataBind();

                con.Close();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        protected void pnd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();




                OracleCommand cmd = new OracleCommand("UPDATE users SET acc_status='pending' WHERE userid='" + TextBox1.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();


                Response.Write("<script>alert('" + TextBox1.Text.Trim() + "`s Account Status Updated Succesfully.');</script>");
                clearfrom();
                GridView1.DataBind();

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        protected void dis_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();




                OracleCommand cmd = new OracleCommand("UPDATE users SET acc_status='disabled' WHERE userid='" + TextBox1.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();


                Response.Write("<script>alert('" + TextBox1.Text.Trim() + "`s Account Status Updated Succesfully.');</script>");
                clearfrom();
                GridView1.DataBind();

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

    }
}