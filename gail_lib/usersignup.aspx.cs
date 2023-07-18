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
    public partial class usersignup : System.Web.UI.Page
    {
        //connection to DB
        OracleConnection con = new OracleConnection(@"Data Source=orclpdb;User ID=video;Password=video1234;Unicode=True");

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            // Response.Write("<script>alert('testing');</script>");
            string name = TextBox1.Text.Trim();
            string dob = TextBox2.Text.Trim();
            string cont = TextBox3.Text.Trim();
            string email = TextBox4.Text.Trim();
            string state = DropDownList1.Text.Trim();
            string city = TextBox6.Text.Trim();
            string pincode = TextBox7.Text.Trim();
            string add = TextBox5.Text.Trim();
            string userid = TextBox8.Text.Trim();
            string pass = TextBox9.Text.Trim();
            string status = "Pending";






            try
            {
               if(usercheck())
               {
                    newuser();
               }
               else
                {
                    Response.Write("<script>alert('user already exist with this user id ,email or phone number');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

            bool usercheck()
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM users WHERE userid='"+ userid +"'");
                OracleCommand cmd2 = new OracleCommand("SELECT * FROM users WHERE phone='" + cont + "'");

                OracleDataAdapter oda = new OracleDataAdapter(cmd.CommandText, con);
                OracleDataAdapter oda2 = new OracleDataAdapter(cmd2.CommandText, con);

                DataTable tab = new DataTable();
                DataTable tab2 = new DataTable();

                oda.Fill(tab);
                oda2.Fill(tab2);

                if (tab.Rows.Count > 0 || tab2.Rows.Count > 0)
                    return false;
                else
                    return true;

            
            }

            void newuser()
            {
                con.Open();

                string query = "INSERT INTO users VALUES('" + name + "','" + dob + "','" + cont + "','" + email + "','" + state + "','" + city + "','" + pincode + "','" + add + "','" + userid + "','" + pass + "','" + status + "')";


                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();


                Response.Write("<script>alert('Sign Up Succesfull.Go to login page');</script>");


                con.Close();
            }


            
        }
    }
}