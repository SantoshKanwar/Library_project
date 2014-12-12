        
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
    public partial class Department_entry : System.Web.UI.Page        
    {        
        DepartmentHandler A_Handler = null;        
        Department A1 = null;
        string MSG;  
         protected void Page_Load(object sender, EventArgs e)        
        {        
            if (!IsPostBack)        
            {        
                if (Request.QueryString["id"] != null)        
                {                            
                    A1 = new Department();        
                    int ID = Convert.ToInt32(Request.QueryString["id"]);        
                    show_data(ID);        
                }        
            }        
        }        
        
        public void show_data(int ID)        
        {        
            A_Handler = new DepartmentHandler();        
            A1 = new Department();        
            A1 = A_Handler.GetDepartmentDetails(ID);        
                      
                
            txtDep_id.Text = A1.Dep_id.ToString();        
                
            ddlReg_id.SelectedValue = A1.Reg_id.ToString();        
                
            txtDep_name.Text = A1.Dep_name.ToString();        
                
            txtDep_code.Text = A1.Dep_code.ToString();        
                      
            btnSubmit.Text = "Update";        
            btnReset.Text = "Cancel";        
            
            if (Request.QueryString["action"] == "del")        
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtDep_id.ReadOnly = false;        
                ddlReg_id.Enabled = false;        
                txtDep_name.ReadOnly = false;        
                txtDep_code.ReadOnly = false;        
                btnSubmit.Text = "Delete";                        
            }        
        
        }        
        protected void btnSubmit_Click(object sender, EventArgs e)        
        {        
            A_Handler = new DepartmentHandler();        
            A1 = new Department();        
        
        
            //A1.Dep_id = Convert.ToInt32(txtDep_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);        
            A1.Dep_name = txtDep_name.Text;        
            A1.Dep_code = txtDep_code.Text;        
        
                    
        
            if (btnSubmit.Text == "Submit")        
            {        
                bool B = A_Handler.AddNewDepartment(A1);        
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
                A1.Dep_id = Convert.ToInt32(txtDep_id.Text);        
                bool B = A_Handler.UpdateDepartment(A1);        
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
                A1.Dep_id = Convert.ToInt32(txtDep_id.Text);        
                bool B = A_Handler.DeleteDepartment(A1);        
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
        
            //Response.Redirect("~/ADMIN/Department_list.aspx?msg="+MSG);        
        }        
        
        protected void btnReset_Click(object sender, EventArgs e)        
        {        
            if (btnReset.Text == "Cancel")        
            {        
                Response.Redirect("~/ADMIN/Department_list.aspx");        
            }        
            else        
            {        
                txtDep_id.Text = "";        
                ddlReg_id.SelectedIndex = -1;        
                txtDep_name.Text = "";        
                txtDep_code.Text = "";
                Label1.Text = "";
                btnSubmit.Text = "Submit";        
            }        
        }        
    }        
}        
        
        

