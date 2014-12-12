        
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
    public partial class Registration_entry : System.Web.UI.Page        
    {        
        RegistrationHandler A_Handler = null;        
        Registration A1 = null;
        string MSG;  
         protected void Page_Load(object sender, EventArgs e)        
        {        
            if (!IsPostBack)        
            {        
                if (Request.QueryString["id"] != null)        
                {                            
                    A1 = new Registration();        
                    int ID = Convert.ToInt32(Request.QueryString["id"]);        
                    show_data(ID);        
                }        
            }        
        }        
        
        public void show_data(int ID)        
        {        
            A_Handler = new RegistrationHandler();        
            A1 = new Registration();        
            A1 = A_Handler.GetRegistrationDetails(ID);        
                      
                
            txtReg_id.Text = A1.Reg_id.ToString();        
                
            txtUsername.Text = A1.Username.ToString();        
                
            txtPassword.Text = A1.Password.ToString();        
                
            txtF_name.Text = A1.F_name.ToString();        
                
            txtL_name.Text = A1.L_name.ToString();        
                
            txtAddress.Text = A1.Address.ToString();        
                
            txtCity.Text = A1.City.ToString();        
                
            txtPhone.Text = A1.Phone.ToString();        
                
            txtMobile.Text = A1.Mobile.ToString();        
                
            txtEmail.Text = A1.Email.ToString();        
                
            DdlSeq_que.SelectedValue = A1.Seq_que.ToString();        
                
            txtAnswer.Text = A1.Answer.ToString();

            if (A1.Photo.ToString() != null)
            {
                Image1.ImageUrl = ("~/img/" + A1.Photo.ToString()); ;
            }
            else
            {
                Image1.ImageUrl =("~/img/000.jpg");
            }
                
            DdlStatus.Text = A1.Status.ToString();        
                      
            btnSubmit.Text = "Update";        
            btnReset.Text = "Cancel";        
            
            if (Request.QueryString["action"] == "del")        
            {        
                txtReg_id.ReadOnly = false;
                txtUsername.ReadOnly = false;
                txtPassword.ReadOnly = false;
                txtF_name.ReadOnly = false;
                txtL_name.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtCity.ReadOnly = false;
                txtPhone.ReadOnly = false;
                txtMobile.ReadOnly = false;
                txtEmail.ReadOnly = false;
                DdlSeq_que.Enabled = false;
                txtAnswer.ReadOnly = false;
                FileUpload1.Enabled = false;
                DdlStatus.Enabled = false;        
                btnSubmit.Text = "Delete";                        
            }        
        
        }        
        protected void btnSubmit_Click(object sender, EventArgs e)        
        {        
            A_Handler = new RegistrationHandler();        
            A1 = new Registration();        
        
        
            //A1.Reg_id = Convert.ToInt32(txtReg_id.Text);        
            A1.Username = txtUsername.Text;        
            A1.Password = txtPassword.Text;        
            A1.F_name = txtF_name.Text;        
            A1.L_name = txtL_name.Text;        
            A1.Address = txtAddress.Text;        
            A1.City = txtCity.Text;        
            A1.Phone = txtPhone.Text;        
            A1.Mobile = Convert.ToDecimal(txtMobile.Text);        
            A1.Email = txtEmail.Text;        
            A1.Seq_que = DdlSeq_que.Text;        
            A1.Answer = txtAnswer.Text;
            
            A1.Photo = "000.jpg";

            if (FileUpload1.HasFile == true)
            {
                FileUpload1.SaveAs(Server.MapPath("~/img") + "/" + FileUpload1.FileName);

               A1.Photo  = FileUpload1.FileName;
            }  
            A1.Status = Convert.ToInt32(DdlStatus.Text);        
        
                 
        
            if (btnSubmit.Text == "Submit")        
            {        
                bool B = A_Handler.AddNewRegistration(A1);        
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
                A1.Reg_id = Convert.ToInt32(txtReg_id.Text);        
                bool B = A_Handler.UpdateRegistration(A1);        
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
                A1.Reg_id = Convert.ToInt32(txtReg_id.Text);        
                bool B = A_Handler.DeleteRegistration(A1);        
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
        
            Response.Redirect("~/ADMIN/Registration_list.aspx?msg="+MSG);        
        }        
        
        protected void btnReset_Click(object sender, EventArgs e)        
        {        
            if (btnReset.Text == "Cancel")        
            {        
                Response.Redirect("~/ADMIN/Registration_list.aspx");        
            }        
            else        
            {        
                txtReg_id.Text = "";        
                txtUsername.Text = "";        
                txtPassword.Text = "";        
                txtF_name.Text = "";        
                txtL_name.Text = "";        
                txtAddress.Text = "";        
                txtCity.Text = "";        
                txtPhone.Text = "";        
                txtMobile.Text = "";        
                txtEmail.Text = "";        
                DdlSeq_que.Text = "";        
                txtAnswer.Text = "";        
                        
                DdlStatus.Text = "";        
        
                btnSubmit.Text = "Submit";        
            }        
        }        
    }        
}        
        
        

