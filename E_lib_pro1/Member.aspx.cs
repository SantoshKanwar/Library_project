using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AURO.BLL;
using AURO.DAL;
//using E_Libpro.My_Function;
namespace E_lib_pro1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        //MyClass my = new MyClass();
        MemberHandler A_Handler = null;
        Member A1 = null;
        string MSG;
        protected void Page_Load(object sender, EventArgs e)
        {
            //my.FillCombo(ddlDes_id, "Designation", "Des_name", "Des_id", "");
            //my.FillCombo(ddlDep_id, "Department", "Dep_name", "Dep_id", "");
            //my.FillCombo(ddlCollege_id, "College", "College_Name", "College_id", "");
        }

      
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new MemberHandler();
            A1 = new Member();


            //A1.Mem_id = Convert.ToInt32(txtMem_id.Text);        
            A1.Reg_id = 1;
            A1.Username = txtUsername.Text;
            A1.Password = txtPassword.Text;
            A1.F_name = txtF_name.Text;
            A1.L_name = txtL_name.Text;
            if (RadioButton1.Checked == true)
            {

                A1.Gender = "Male";
            }
            else
            {
                A1.Gender = "Female";
            }
            A1.Dob = Convert.ToDateTime(txtDob.Text);
            A1.Address = txtAddress.Text;
            A1.City = txtCity.Text;
            A1.Phone = txtPhone.Text;
            A1.Role = DropDownList1.SelectedValue;
            A1.Mobile = Convert.ToDecimal(txtMobile.Text);
            A1.Email = txtEmail.Text;
            //A1.Photo = txtPhoto.Text;    
            A1.Photo = "000.jpg";

            if (FileUpload1.HasFile == true)
            {
                FileUpload1.SaveAs(Server.MapPath("~/img") + "/" + FileUpload1.FileName);

                A1.Photo = FileUpload1.FileName;
            }

            A1.Des_id = Convert.ToInt32(ddlDes_id.SelectedValue);
            A1.Dep_id = Convert.ToInt32(ddlDep_id.SelectedValue);
            A1.College_id = Convert.ToInt32(ddlCollege_id.SelectedValue);
            A1.Member_code = txtUsername.Text + 2013;
            A1.Status = 1;

            //      

            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewMember(A1);
                if (B == true)
                {
                    Label1.Text = "SucessFull Registration";
                    MSG = "SucessFull Registration";
                }
                else
                {
                    Label1.Text = "Registration Not SucessFully";
                    MSG = "Registration Not SucessFully";
                }
            }
          
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
             
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtF_name.Text = "";
                txtL_name.Text = "";
                RadioButton1.Checked = true;
                txtDob.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtPhone.Text = "";
                DropDownList1.SelectedIndex = -1;
                txtMobile.Text = "";
                txtEmail.Text = "";
                // txtPhoto.Text = "";        
                ddlDes_id.SelectedIndex = -1;
                ddlDep_id.SelectedIndex = -1;
                ddlCollege_id.SelectedIndex = -1;
                Label1.Text = "";
            
        }
    }
}



