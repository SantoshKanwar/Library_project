using System;
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


using AURO.BLL;
using AURO.DAL;
//using E_Libpro.My_Function;
namespace E_lib_pro1.USER
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        //MyClass my = new MyClass();
        MemberHandler A_Handler = null;
        Member A1 = null;
        string MSG;
        int mem_id;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["mem_id"] != null)
            {
                mem_id = Int32.Parse(Session["mem_id"].ToString());
                show_data(mem_id);

            }
            //my.FillCombo(ddlDes_id, "Designation", "Des_name", "Des_id", "");
            //my.FillCombo(ddlDep_id, "Department", "Dep_name", "Dep_id", "");
            //my.FillCombo(ddlCollege_id, "College", "College_Name", "College_id", "");
            
        }

        public void show_data(int ID)
        {
            A_Handler = new MemberHandler();
            A1 = new Member();
            A1 = A_Handler.GetMemberDetails(ID);


            txtMem_id.Text = A1.Mem_id.ToString();
            ddlReg_id.SelectedValue = A1.Reg_id.ToString();
            txtUsername.Text = A1.Username.ToString();
            txtPassword.Text = A1.Password.ToString();
            txtF_name.Text = A1.F_name.ToString();
            txtL_name.Text = A1.L_name.ToString();

            if (A1.Gender == "Male")
            {
                RadioButton1.Checked = true;
            }
            else
            {
                RadioButton2.Checked = false;
            }


            txtDob.Text = A1.Dob.ToString();

            txtAddress.Text = A1.Address.ToString();

            txtCity.Text = A1.City.ToString();

            txtPhone.Text = A1.Phone.ToString();

            DropDownList1.SelectedValue = A1.Role.ToString();

            txtMobile.Text = A1.Mobile.ToString();

            txtEmail.Text = A1.Email.ToString();

            //txtPhoto.Text = A1.Photo.ToString();    
            if (A1.Photo.ToString() != null)
            {
                Image1.ImageUrl = ("~/img/" + A1.Photo.ToString()); ;
            }
            else
            {
                Image1.ImageUrl = ("~/img/000.jpg");
            }

            ddlDes_id.SelectedValue = A1.Des_id.ToString();

            ddlDep_id.SelectedValue = A1.Dep_id.ToString();

            ddlCollege_id.SelectedValue = A1.College_id.ToString();

            txtMember_code.Text = A1.Member_code.ToString();

            DropDownList2.SelectedValue = A1.Status.ToString();

            btnSubmit.Text = "Update";
            btnReset.Text = "Cancel";

           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new MemberHandler();
            A1 = new Member();


            //A1.Mem_id = Convert.ToInt32(txtMem_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);
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
            A1.Member_code = txtMember_code.Text;
            A1.Status = Convert.ToInt32(DropDownList2.SelectedValue);

            

            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewMember(A1);
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
            else
            {
                A1.Mem_id = Convert.ToInt32(txtMem_id.Text);

                bool B = A_Handler.UpdateMember(A1);
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
                          
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text == "Cancel")
            {
                Response.Redirect("~/ADMIN/Member_list.aspx");
            }
            else
            {
                txtMem_id.Text = "";
                ddlReg_id.SelectedIndex = -1;
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
                txtMember_code.Text = "";
                DropDownList2.SelectedIndex = -1;
                Label1.Text = "";
                btnSubmit.Text = "Submit";
            }
        }
    }
}



