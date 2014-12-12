using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_lib_pro1.LIBRARIAN
{
    public partial class Librian : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Label1.Text = Session["user"].ToString();
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}