using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;using System.Web.UI;using System.Web.UI.WebControls;
using System.Data.SqlClient;


using AURO.BLL;
using AURO.DAL;        
        
namespace AURO.ADMIN        
{        
    public partial class Registration_list : System.Web.UI.Page        
    {        
        
        RegistrationHandler A_Handler = null;        
        
        string Tbl_Name = "[Registration]";        
        string Entry_Page = "Registration_entry.aspx";        
        
        string sql = "";        
        string fld = "";        
        string txt = "";        
        
        
        protected void Page_Load(object sender, EventArgs e)        
        {        
        
            //lblResult.Text = string.Empty;        
        
            //A_Handler = new RegistrationHandler();        
        
            //if (IsPostBack == false)        
            //{        
            //    Grid1.DataSource = A_Handler.GetRegistrationList();        
            //    Grid1.DataBind();        
            //    if (Grid1.Rows.Count > 0)        
            //    {        
            //        lblRec.Text = "Total Records : " + Grid1.Rows.Count.ToString();        
            //    }        
            //    else        
            //    {        
            //        lblRec.Text = "Record Not Found...";        
            //    }        
           // }        
        
        
        }        
        
        protected void btnShow_Click(object sender, EventArgs e)        
        {        
            fld = cboSearch.SelectedValue.ToString();        
            txt = txtSearch.Text;        
            A_Handler = new RegistrationHandler();        
            sql = "select * from " + Tbl_Name + " where " + fld + " like '" + txt + "%' ";        
            //Grid1.DataSource = A_Handler.GetRegistrationList(sql);        
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
            Response.Redirect( Entry_Page + "?id=" + id);        
        }        
        
        
    }        
}        
        
        

