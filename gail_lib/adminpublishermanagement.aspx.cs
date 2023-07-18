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

    public partial class adminpublishermanagement : System.Web.UI.Page
    {
        OracleConnection con = new OracleConnection(@"Data Source = orclpdb; User ID = video; Password=video1234;Unicode=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        // add publisher
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkPublisherExists())
            {
                Response.Write("<script>alert('Publisher Already Exist with this ID.');</script>");
            }
            else
            {
                addNewPublisher();
            }
        }
        // update publisher
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkPublisherExists())
            {
                updatePublisherByID();
            }
            else
            {
                Response.Write("<script>alert('Publisher with this ID does not exist');</script>");
            }
        }
        // delete publisher
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkPublisherExists())
            {
                deletePublisherByID();
            }
            else
            {
                Response.Write("<script>alert('Publisher with this ID does not exist');</script>");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            getPublisherByID();
        }




        // user defined functions

        void getPublisherByID()
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OracleCommand cmd = new OracleCommand("SELECT * from publishers where publisherid='" + TextBox1.Text.Trim() + "'", con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
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

        bool checkPublisherExists()
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OracleCommand cmd = new OracleCommand("SELECT * from publishers where publisherid='" + TextBox1.Text.Trim() + "'", con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void addNewPublisher()
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OracleCommand cmd = new OracleCommand("INSERT INTO publishers values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "')", con);

                


                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Publisher added successfully.');</script>");
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        public void updatePublisherByID()
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

               
                OracleCommand cmd = new OracleCommand("update publishers set name='" + TextBox2.Text.Trim() + "' WHERE publisherid='" + TextBox1.Text.Trim() + "'", con);
                
                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {

                    Response.Write("<script>alert('Publisher Updated Successfully');</script>");
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Publisher ID does not Exist');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        public void deletePublisherByID()
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                OracleCommand cmd = new OracleCommand("Delete from publishers WHERE publisherid='" + TextBox1.Text.Trim() + "'", con);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {

                    Response.Write("<script>alert('Publisher Deleted Successfully');</script>");
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Publisher ID does not Exist');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

    }
}
