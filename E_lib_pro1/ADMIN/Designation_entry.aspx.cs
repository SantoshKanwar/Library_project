        
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
    public partial class Designation_entry : System.Web.UI.Page        
    {        
        DesignationHandler A_Handler = null;        
        Designation A1 = null;
        string MSG;  
         protected void Page_Load(object sender, EventArgs e)        
        {        
            if (!IsPostBack)        
            {        
                if (Request.QueryString["id"] != null)        
                {                            
                    A1 = new Designation();        
                    int ID = Convert.ToInt32(Request.QueryString["id"]);        
                    show_data(ID);        
                }        
            }        
        }        
        
        public void show_data(int ID)        
        {        
            A_Handler = new DesignationHandler();        
            A1 = new Designation();        
            A1 = A_Handler.GetDesignationDetails(ID);        
                      
                
            txtDes_id.Text = A1.Des_id.ToString();        
                
            ddlReg_id.SelectedValue = A1.Reg_id.ToString();        
                
            txtDes_name.Text = A1.Des_name.ToString();        
                
            txtDes_code.Text = A1.Des_code.ToString();        
                
            DropDownList1.SelectedValue = A1.IsTeaching.ToString();        
                      
            btnSubmit.Text = "Update";        
            btnReset.Text = "Cancel";        
            
            if (Request.QueryString["action"] == "del")        
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtDes_id.ReadOnly = true;        
                ddlReg_id.Enabled = false;        
                txtDes_name.ReadOnly = true;        
                txtDes_code.ReadOnly = true;        
                DropDownList1.Enabled = true;        
                btnSubmit.Text = "Delete";                        
            }        
        
        }        
        protected void btnSubmit_Click(object sender, EventArgs e)        
        {        
            A_Handler = new DesignationHandler();        
            A1 = new Designation();        
        
        
            //A1.Des_id = Convert.ToInt32(txtDes_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);        
            A1.Des_name = txtDes_name.Text;        
            A1.Des_code = Convert.ToInt32(txtDes_code.Text);        
            A1.IsTeaching = Convert.ToInt32(DropDownList1.Text);        
        
                    
        
            if (btnSubmit.Text == "Submit")        
            {        
                bool B = A_Handler.AddNewDesignation(A1);        
                if (B == true)        
                {        
                    Label1.Text = "Record Inserted";        
                    MSG = "Record Inserted";         
                }        
                else        
                {        
                    Label1.Text = "Record Not Inserted";        
                    MSG = "Record Not Inserted";         
                }        
            }        
            else if(btnSubmit.Text == "Update")        
            {        
                A1.Des_id = Convert.ToInt32(txtDes_id.Text);        
                bool B = A_Handler.UpdateDesignation(A1);        
                if (B == true)        
                {        
                    Label1.Text = "Record Updated";        
                    MSG = "Record Not Updated";         
                }        
                else        
                {        
                    Label1.Text = "Record Not Updated";        
                    MSG = "Record Not Updated";         
                }        
            }        
            else if (btnSubmit.Text == "Delete")        
            {        
                A1.Des_id = Convert.ToInt32(txtDes_id.Text);        
                bool B = A_Handler.DeleteDesignation(A1);        
                if (B == true)        
                {        
                    Label1.Text = "Record Deleted";        
                    MSG = "Record Deleted";        
                }        
                else        
                {        
                    Label1.Text = "Record Not Deleted";        
                    MSG = "Record Not Deleted";        
                }        
            }        
        
            //Response.Redirect("~/ADMIN/Designation_list.aspx?msg="+MSG);        
        }        
        
        protected void btnReset_Click(object sender, EventArgs e)        
        {        
            if (btnReset.Text == "Cancel")        
            {        
                Response.Redirect("~/ADMIN/Designation_list.aspx");        
            }        
            else        
            {        
                txtDes_id.Text = "";        
                ddlReg_id.SelectedIndex = -1;        
                txtDes_name.Text = "";        
                txtDes_code.Text = "";        
                DropDownList1.Text = "";
                Label1.Text = "";
                btnSubmit.Text = "Submit";        
            }        
        }        
    }        
}        
        
        

