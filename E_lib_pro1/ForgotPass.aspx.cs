using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace E_lib_pro1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True";
        string sql = "";
        SqlCommand cmd;
        SqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string email = TextBox2.Text;


            sql = "select Password from Member where username = '" + username + "' and  email = '" + email + "' ";
            cmd = new SqlCommand(sql, conn);
            conn.Open();

            object c = cmd.ExecuteScalar();


            conn.Close();
            if (c != null)
            {
                string Message = "Password Recover...\n\n";
                Message += " Your Password is Successfully Received.\n";
                Message += " Password is :" + c.ToString() + "\n";

                try
                {

                    MailSender.SendEmail("vngurjar11@gmail.com", "vj@12345", email, "Thanks For Using E-LibPro System", Message, System.Web.Mail.MailFormat.Html, "");


                    Label1.Text = "Mail Sent Successfully.";
                }
                catch (Exception ex)
                {
                    //lblError.Text = ex.Message;
                }


                //Label1.Text = "Your Password Is : " + c.ToString();

            }
        }
    }
}