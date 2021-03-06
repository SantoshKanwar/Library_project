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

namespace E_lib_pro1.LIBRARIAN
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        MemberHandler A_Handler = null;

        string Tbl_Name = "[VMember]";
        string Entry_Page = "Member_entry.aspx";

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
            //lblResult.Text = string.Empty;        

            //A_Handler = new MemberHandler();

            //if (IsPostBack == false)
            //{
            //    //Grid1.DataSource = A_Handler.GetMemberList();
            //    //Grid1.DataBind();
            //    if (Grid1.Rows.Count > 0)
            //    {
            //        lblRec.Text = "Total Records : " + Grid1.Rows.Count.ToString();
            //    }
            //    else
            //    {
            //        lblRec.Text = "Record Not Found...";
            //    }
            //}        


        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            fld = cboSearch.SelectedValue.ToString();
            txt = txtSearch.Text;
            A_Handler = new MemberHandler();
            sql = "select * from " + Tbl_Name + " where " + fld + " like '" + txt + "%' ";
            //Grid1.DataSource = A_Handler.GetMemberList(sql);        
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
            Response.Redirect("~/Report/Rpt_Member.aspx");
        }


    }
}