using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

using E_Libpro.My_Function;
using AURO.BLL;
using AURO.DAL;  

namespace E_lib_pro1.LIBRARIAN
{
    public partial class WebForm28 : System.Web.UI.Page
    {
       Book_Issue_entry A_Handler = null;

        string Tbl_Name = "[VBook_Issue]";
        string Entry_Page = "Book_Issue_entry.aspx";

        string sql = "";
        string fld = "";
        string txt = "";
        int cid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            MyClass my = new MyClass();
            if (Session["College_id"] != null)
            {
                cid = int.Parse(Session["College_id"].ToString());

                Label1.Text = cid.ToString();
                Label2.Text = my.Get_College(cid);
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {

            fld = cboSearch.SelectedValue.ToString();
            txt = txtSearch.Text;
            A_Handler = new Book_Issue_entry();
            sql = "select * from " + Tbl_Name + " where COL_ID =" + cid + " and  " + fld + " like '" + txt + "%' ";

            SqlDataSource1.SelectCommand = sql;
            SqlDataSource1.DataBind();
        }

        protected void btnNewEntry_Click(object sender, EventArgs e)
        {
            Response.Redirect(Entry_Page);
        }

        protected void Grid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = Grid1.SelectedRow.Cells[2].Text;
            Response.Redirect(Entry_Page + "?id=" + id);
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Report/Rpt_Book_Issue.aspx");
        }
    }
}