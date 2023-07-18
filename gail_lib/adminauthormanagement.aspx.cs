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
    public partial class adminauthormanagement : System.Web.UI.Page
    {
        OracleConnection con = new OracleConnection(@"Data Source = orclpdb; User ID = video; Password=video1234;Unicode=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
           // GridView1.UseAccessibleHeader = true;
           // GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        //Go button
        protected void Button1_Click(object sender, EventArgs e)
        {
            string authorid = TextBox1.Text.Trim();
            try
            {
                if (usercheck(authorid))
                {
                    Response.Write("<script>alert('author does not exist with this author id');</script>");
                    
                }
                else
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM authors WHERE authorid='" + authorid + "'");


                    OracleDataAdapter oda = new OracleDataAdapter(cmd.CommandText, con);


                    DataTable tab = new DataTable();


                    oda.Fill(tab);

                    TextBox2.Text = tab.Rows[0][1].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        //Add button
        protected void Button2_Click(object sender, EventArgs e)
        {
            string authorid = TextBox1.Text.Trim();
            try
            {
                if (usercheck(authorid))
                {
                    newauthor(authorid);
                }
                else
                {
                    Response.Write("<script>alert('author already exist with this author id');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        //update button
        protected void Button3_Click(object sender, EventArgs e)
        {
            string authorid = TextBox1.Text.Trim();
            try
            {
                if (usercheck(authorid))
                {
                    Response.Write("<script>alert('author does not exist with this author id');</script>");
                    
                }
                else
                {
                    updateauthor(authorid);
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        //delete button
        protected void Button4_Click(object sender, EventArgs e)
        {
            string authorid = TextBox1.Text.Trim();
            try
            {
                if (usercheck(authorid))
                {
                    Response.Write("<script>alert('author does not exist with this author id');</script>");

                }
                else
                {
                    deleteauthor(authorid);
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deleteauthor(string authorid)
        {
            con.Open();

            string query = "DELETE FROM authors WHERE authorid='" + authorid + "'";


            OracleCommand cmd = new OracleCommand(query, con);
            cmd.ExecuteNonQuery();


            Response.Write("<script>alert('Author daleted Succesfully.');</script>");
            clearfrom();
            GridView1.DataBind();

            con.Close();
        }

        void updateauthor(string authorid)
        {
            con.Open();

            string query = "UPDATE authors SET name='" + TextBox2.Text.Trim() + "' WHERE authorid='" +authorid+ "'";


            OracleCommand cmd = new OracleCommand(query, con);
            cmd.ExecuteNonQuery();


            Response.Write("<script>alert('Author name Updated Succesfully.');</script>");
            clearfrom();
            GridView1.DataBind();

            con.Close();
        }

        void newauthor( string authorid)
        {
            con.Open();

            string query = "INSERT INTO authors VALUES('" + authorid + "','" + TextBox2.Text.Trim() + "')";


            OracleCommand cmd = new OracleCommand(query, con);
            cmd.ExecuteNonQuery();


            Response.Write("<script>alert('Author Added Succesfully.');</script>");
            clearfrom();
            GridView1.DataBind();

            con.Close();
        }


        bool usercheck(string authorid)
        {
            OracleCommand cmd = new OracleCommand("SELECT * FROM authors WHERE authorid='" + authorid + "'");
            

            OracleDataAdapter oda = new OracleDataAdapter(cmd.CommandText, con);
         

            DataTable tab = new DataTable();
           

            oda.Fill(tab);
          

            if (tab.Rows.Count > 0)
                return false;
            else
                return true;


        }

        void clearfrom()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";

        }
    }
}