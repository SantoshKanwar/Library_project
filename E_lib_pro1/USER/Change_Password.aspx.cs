using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace E_lib_pro1.USER
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True";
        string sql = "";


        string username;
        string password;
        string newpassword;
        string confirmpassword;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            username = TextBox1.Text;
            password = TextBox2.Text;
            newpassword = TextBox3.Text;
            confirmpassword = TextBox4.Text;




            sql = "update Member set password='" + newpassword + "' where username = '" + username + "' and [password] = '" + password + "' ";

            cmd = new SqlCommand(sql, conn);
            conn.Open();
            int c = cmd.ExecuteNonQuery();

            if (c > 0)
            {
                Label1.Text = "Your Password Is Changed...";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }
            else
            {
                Label1.Text = "Wrong User Or Password...";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
              TextBox1.Text = "";
          TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
  
        }
    }
}