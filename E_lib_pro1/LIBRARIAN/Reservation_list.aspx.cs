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
    public partial class WebForm23 : System.Web.UI.Page
    {

        ReservationHandler A_Handler = null;

       
        string Tbl_Name = "[VReservation]";
        //string Entry_Page = "Setting_entry.aspx";

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

        protected void btnShow_Click(object sender, EventArgs e)
        {
            fld = cboSearch.SelectedValue.ToString();
            txt = txtSearch.Text;
            A_Handler = new ReservationHandler();
            sql = "select * from " + Tbl_Name + " where " + fld + " like '" + txt + "%' ";
            //Grid1.DataSource = A_Handler.GetSettingList(sql);        
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

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Report/Rpt_Reservation.aspx");
        }

       
         


    }
}