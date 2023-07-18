using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;

namespace gail_lib
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  Lb1.Visible = false;
          ////  TextBox1.Text=null;
          ////  TextBox2.Text=null;

          //  //db connection
          //  OracleConnection conn = new OracleConnection(@"Data Source=orclpdb;User ID=video;Password=video1234;Unicode=True");
          //  conn.Open();

          //  DataTable tab = new DataTable();
          //  OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM login", conn);
          //  da.Fill(tab);

          //  GridView1.DataSource = tab;
          //  GridView1.DataBind();

          //  conn.Close();
          //  conn.Dispose();
        }

        //protected void SearchButton_Click(object sender, EventArgs e)
        //{

        //    //db connection
        //    OracleConnection conn2 = new OracleConnection(@"Data Source=orclpdb;User ID=video;Password=video1234;Unicode=True");
        //    conn2.Open();


        //    string uid = TextBox1.Text.Trim();
        //    string unm = TextBox2.Text.Trim();
        //    /*OracleCommand c = new OracleCommand("INSERT INTO login VALUES('" + uid + "','" + unm + "')",conn2);
        //    c.ExecuteNonQuery();*/

        //    string query = "SELECT * FROM login WHERE userid = '"+uid+"' AND name = '"+unm+"' ";
            

        //    OracleCommand com = new OracleCommand(query); 

        //    DataTable tab2 = new DataTable();
        //    OracleDataAdapter da2 = new OracleDataAdapter(com.CommandText, conn2);

        //    da2.Fill(tab2);

        //    int count = tab2.Rows.Count;
        //    if(count==1)
        //    {
        //        GridView2.DataSource = tab2;
        //        GridView2.DataBind();
        //      // Session["name"] = unm;
        //     //  Response.Redirect("dashboard.aspx");
        //    }
        //    else
        //    {
        //        Lb1.Visible = true;
        //    }
        //    /*for (int i = 0; i < count; i++)
        //    {
        //       string userid = tab2.Rows[i]["userid"].ToString();
        //       string name= tab2.Rows[i]["name"].ToString();
        //        if(userid == uid&&name == unm)
        //        {
        //            Session["name"] = name;
        //            Response.Redirect("dashboard.aspx");
        //        }
        //        else
        //        {
        //            Lb1.Visible=true;
        //        }
        //    }*/


            

        //    conn2.Close();
        //    conn2.Dispose();

        //}
    }
}