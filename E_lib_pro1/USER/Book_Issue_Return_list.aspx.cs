﻿using System;
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

namespace E_lib_pro1.USER
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Book_Issue_ReturnHandler A_Handler = null;

        string Tbl_Name = "[VBook_Issue_Return]";
        string Entry_Page = "Book_Issue_Return_entry.aspx";

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
                //lblResult.Text = string.Empty;        

                //A_Handler = new Book_Issue_ReturnHandler();        

                //if (IsPostBack == false)        
                //{
                //    Grid1.DataSource = A_Handler.GetList();
                //    Grid1.DataBind();        
                if (Grid1.Rows.Count > 0)
                {
                    lblRec.Text = "Total Records : " + Grid1.Rows.Count.ToString();
                }
                else
                {
                    lblRec.Text = "Record Not Found...";
                }
            }
        }



        protected void btnShow_Click(object sender, EventArgs e)
        {
            fld = cboSearch.SelectedValue.ToString();
            txt = txtSearch.Text;
            A_Handler = new Book_Issue_ReturnHandler();
            sql = "select * from " + Tbl_Name + " where COL_ID =" + cid + " and " + fld + " like '" + txt + "%' ";
            //Grid1.DataSource = A_Handler.GetList(sql);        
            //Grid1.DataBind();

            SqlDataSource1.SelectCommand = sql;
            SqlDataSource1.DataBind();
            if (Grid1.Rows.Count > 0)
            {
                lblRec.Text = "Total Records : " + Grid1.Rows.Count.ToString();
            }
            else
            {
                lblRec.Text = "Record Not Found...";
            }

        }

        
 

    }
}
