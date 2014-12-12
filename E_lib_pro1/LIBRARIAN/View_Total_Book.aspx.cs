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

namespace E_lib_pro1.LIBRARIAN
{
    public partial class WebForm27 : System.Web.UI.Page
    {
        string Tbl_Name = "[ViewAcc_book_Ava]";
        //string Entry_Page = "Book_Master_entry.aspx";

        string sql = "";
        string fld = "";
        string txt = "";
        int cid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            MyClass my = new MyClass();
            if (IsPostBack == false)
            {
                if (Session["College_id"] != null)
                {
                    cid = int.Parse(Session["College_id"].ToString());

                    Label1.Text = cid.ToString();
                    Label2.Text = my.Get_College(cid);

                    sql = "select * from " + Tbl_Name + " where COLLEGE_ID =" + cid + " ";
                    SqlDataSource1.SelectCommand = sql;
                    SqlDataSource1.DataBind();
                }
            }
        }

       

       

        protected void btnShow_Click1(object sender, EventArgs e)
        {
            fld = cboSearch.SelectedValue.ToString();
            txt = txtSearch.Text;

            sql = "select * from " + Tbl_Name + " where " + fld + " like '" + txt + "%' ";
            //Grid1.DataSource = A_Handler.GetFineList(sql);        
            //Grid1.DataBind();   
            SqlDataSource1.SelectCommand = sql;
            SqlDataSource1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Report/Rpt_ViewTotalbook.aspx");
        }

       
    }
}