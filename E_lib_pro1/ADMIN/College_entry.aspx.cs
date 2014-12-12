        
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
    public partial class College_entry : System.Web.UI.Page        
    {        
        CollegeHandler A_Handler = null;        
        College A1 = null;
        string MSG;  
         protected void Page_Load(object sender, EventArgs e)        
        {        
            if (!IsPostBack)        
            {        
                if (Request.QueryString["id"] != null)        
                {                            
                    A1 = new College();        
                    int ID = Convert.ToInt32(Request.QueryString["id"]);        
                    show_data(ID);        
                }        
            }        
        }        
        
        public void show_data(int ID)        
        {        
            A_Handler = new CollegeHandler();        
            A1 = new College();        
            A1 = A_Handler.GetCollegeDetails(ID);        
                      
                
            txtCollege_id.Text = A1.College_id.ToString();        
                
            ddlReg_id.Text = A1.Reg_id.ToString();        
                
            txtCollege_Name.Text = A1.College_Name.ToString();        
                
            txtAddress.Text = A1.Address.ToString();        
                
           // txtCity.Text = A1.City.ToString();        
                
            txtPhone.Text = A1.Phone.ToString();        
                
            txtMobile.Text = A1.Mobile.ToString();        
                
            txtFax.Text = A1.Fax.ToString();        
                
            txtEmail.Text = A1.Email.ToString();        
                
            txtWebsite.Text = A1.Website.ToString();        
                
            txtCollege_code.Text = A1.College_code.ToString();        
                
            txtPrefix.Text = A1.Prefix.ToString();        
                
            DdlStatus.SelectedValue = A1.Status.ToString();        
                      
            btnSubmit.Text = "Update";        
            btnReset.Text = "Cancel";        
            
            if (Request.QueryString["action"] == "del")        
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtCollege_id.ReadOnly = false;
                ddlReg_id.Enabled = false;
                txtCollege_Name.ReadOnly = false;
                txtAddress.ReadOnly = false;
                //txtCity.ReadOnly = false;
                txtPhone.ReadOnly = false;
                txtMobile.ReadOnly = false;
                txtFax.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtWebsite.ReadOnly = false;
                txtCollege_code.ReadOnly = false;
                txtPrefix.ReadOnly = false;        
                DdlStatus.Enabled = false;        
                btnSubmit.Text = "Delete";                        
            }        
        
        }        
        protected void btnSubmit_Click(object sender, EventArgs e)        
        {        
            A_Handler = new CollegeHandler();        
            A1 = new College();        
        
        
            //A1.College_id = Convert.ToInt32(txtCollege_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);        
            A1.College_Name = txtCollege_Name.Text;        
            A1.Address = txtAddress.Text;        
           // A1.City = txtCity.Text;        
            A1.Phone = txtPhone.Text;        
            A1.Mobile = Convert.ToDecimal(txtMobile.Text);        
            A1.Fax = txtFax.Text;        
            A1.Email = txtEmail.Text;        
            A1.Website = txtWebsite.Text;        
            A1.College_code = txtCollege_code.Text;        
            A1.Prefix = txtPrefix.Text;        
            A1.Status = Convert.ToInt32(DdlStatus.Text);        
        
                    
        
            if (btnSubmit.Text == "Submit")        
            {        
                bool B = A_Handler.AddNewCollege(A1);        
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
                A1.College_id = Convert.ToInt32(txtCollege_id.Text);        
                bool B = A_Handler.UpdateCollege(A1);        
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
                A1.College_id = Convert.ToInt32(txtCollege_id.Text);        
                bool B = A_Handler.DeleteCollege(A1);        
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
        
            //Response.Redirect("~/ADMIN/College_list.aspx?msg="+MSG);        
        }        
        
        protected void btnReset_Click(object sender, EventArgs e)        
        {        
            if (btnReset.Text == "Cancel")        
            {        
                Response.Redirect("~/ADMIN/College_list.aspx");        
            }        
            else        
            {        
                txtCollege_id.Text = "";        
                ddlReg_id.SelectedIndex = -1;        
                txtCollege_Name.Text = "";        
                txtAddress.Text = "";        
                //txtCity.Text = "";        
                txtPhone.Text = "";        
                txtMobile.Text = "";        
                txtFax.Text = "";        
                txtEmail.Text = "";        
                txtWebsite.Text = "";        
                txtCollege_code.Text = "";        
                txtPrefix.Text = "";        
                DdlStatus.Text = "";
                Label1.Text = "";
                btnSubmit.Text = "Submit";        
            }        
        }        
    }        
}        
        
        

