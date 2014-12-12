using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace E_lib_pro1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        
        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True";
        string sql = "";

        int reg_id;
        int mem_id;
        int college_id;

        string email;
        string password;
        string role;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            email = TextBox1.Text;
            password = TextBox2.Text;

            if (RadioButton1.Checked == true)
            {
                sql = "select * from registration where email = '" + email + "' and [Password] = '" + password + "' ";

                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                dap.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    reg_id = Int32.Parse(dt.Rows[0]["reg_id"].ToString());
                    string user1 = dt.Rows[0]["username"].ToString() ;
                   
                    Session["reg_id"] = reg_id;
                    Session["user"] = user1;
                   

                    Label1.Text = "Welcome To My Site...";
                    Response.Redirect("~/Admin/Default.aspx");


                }
                else
                {
                    Label1.Text = "Wrong User Or Password";

                }
            }

            if (RadioButton2.Checked == true)
            {
                sql = "select * from Member where email = '" + email + "' and [password] = '" + password + "' ";

                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                dap.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    mem_id = Int32.Parse(dt.Rows[0]["mem_id"].ToString());
                    role = dt.Rows[0]["role"].ToString();
                    college_id = Int32.Parse(dt.Rows[0]["college_id"].ToString());


                    Session["mem_id"] = mem_id;
                    Session["user"] = dt.Rows[0]["username"].ToString();
                    Session["college_id"] = college_id;

                    if (role == "STUDENT")
                    {
                        Label1.Text = "Welcome To My Site...";
                        Response.Redirect("~/User/Default.aspx");
                    }

                    if (role == "FACULTY")
                    {
                        Label1.Text = "Welcome To My Site...";
                        Response.Redirect("~/User/Default.aspx");
                    }

                    if (role == "LIBRARIAN")
                    {
                        Label1.Text = "Welcome To My Site...";
                        Response.Redirect("~/LIBRARIAN/Default.aspx");
                    }
                   
                }
                else
                {
                    Label1.Text = "Wrong User Or Password";

                }
            } 

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}