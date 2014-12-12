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
    public partial class Purchase_Master_list : System.Web.UI.Page        
    {        
        
        Purchase_MasterHandler A_Handler = null;        
        
        string Tbl_Name = "[VPurchase_Master]";        
        string Entry_Page = "Purchase_Master_entry.aspx";        
        
        string sql = "";        
        string fld = "";        
        string txt = "";        
        
        
        protected void Page_Load(object sender, EventArgs e)        
        {        
        
            //lblResult.Text = string.Empty;        
        
            //A_Handler = new Purchase_MasterHandler();        
        
            //if (IsPostBack == false)        
            //{        
            //    Grid1.DataSource = A_Handler.GetPurchase_MasterList();        
            //    Grid1.DataBind();        
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
            A_Handler = new Purchase_MasterHandler();        
            sql = "select * from " + Tbl_Name + " where " + fld + " like '" + txt + "%' ";        
            //Grid1.DataSource = A_Handler.GetPurchase_MasterList(sql);        
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
        
               
        
        protected void Grid1_SelectedIndexChanged(object sender, EventArgs e)        
        {        
            string id = Grid1.SelectedRow.Cells[2].Text;        
            Response.Redirect( Entry_Page + "?id=" + id);        
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Report/Rpt_Purchase_Master.aspx");
        }

           
        
        
    }        
}        
        
        

