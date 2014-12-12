using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_lib_pro1.USER
{
    public partial class user : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                //Label1.Text = "<b><font color=#D3F18D>Welcome...   " + Session["user"].ToString();
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}