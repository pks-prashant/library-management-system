using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gail_lib
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (Session["name"]==null)
                {
                    LinkButton1.Visible = true;    //user login
                    LinkButton2.Visible = true;    //user signup
                    LinkButton3.Visible = false;    //log out
                    LinkButton4.Visible = false;     //View Books
                    LinkButton7.Visible = false;    //hello user
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;    //user login
                    LinkButton2.Visible = false;    //user signup
                    LinkButton3.Visible = true;    //log out
                    LinkButton4.Visible = true;     //View Books
                    LinkButton7.Visible = true;    //hello user
                    LinkButton7.Text = "Hello " + Session["name"] + ",";    //user signup

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false;    //user login
                    LinkButton2.Visible = false;    //user signup
                    LinkButton3.Visible = true;    //log out
                    LinkButton4.Visible = false;     //View Books
                    LinkButton7.Visible = true;    //hello user
                    LinkButton7.Text = "Hello " + Session["name"] + ",";    //user signup
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");  
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            
            LinkButton1.Visible = true;    //user login
            LinkButton2.Visible = true;    //user signup
            LinkButton3.Visible = false;    //log out
            LinkButton7.Visible = false;    //hello user
            Response.Redirect("default.aspx");
        }

        protected void admin_login(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

    }
}