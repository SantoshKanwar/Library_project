using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_Libpro.My_Function;
using AURO.DAL;

namespace E_lib_pro1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        Member A1 = new Member();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "update [Member] set [Dep_id]=" + 2 + "  where [Des_id]=" + 6 + " and [College_id]=" + 4 + "";

            MyClass c1 = new MyClass();
            c1.Execute(sql);
            Response.Write("<h1>OK</h1>");

        }

    }
}