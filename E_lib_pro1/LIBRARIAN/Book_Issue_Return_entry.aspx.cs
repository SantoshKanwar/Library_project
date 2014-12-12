
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
namespace E_lib_pro1.LIBRARIAN
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Book_Issue_ReturnHandler A_Handler = null;
        Book_Issue_Return A1 = null;
        string MSG;  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    A1 = new Book_Issue_Return();
                    int ID = Convert.ToInt32(Request.QueryString["id"]);
                    show_data(ID);
                }
            }
        }

        public void show_data(int ID)
        {
            A_Handler = new Book_Issue_ReturnHandler();
            A1 = new Book_Issue_Return();
            A1 = A_Handler.GetBook_Issue_ReturnDetails(ID);


            txtBir_id.Text = A1.Bir_id.ToString();

            ddlReg_id.SelectedValue = A1.Reg_id.ToString();

            ddlMem_id.SelectedValue = A1.Mem_id.ToString();

            ddlAcc_id.SelectedValue = A1.Acc_id.ToString();

            txtIssue_dt.Text = A1.Issue_dt.ToString();

            txtIssue_days.Text = A1.Issue_days.ToString();

            txtDue_dt.Text = A1.Due_dt.ToString();

            txtReturn_dt.Text = A1.Return_dt.ToString();

            txtDue_day.Text = A1.Due_day.ToString();

            DropDownList1.SelectedValue = A1.Is_return.ToString();
            DropDownList2.SelectedValue = A1.Is_fine.ToString();


            //  txtI.Text = A1.Is_return.ToString();        

            // txtIs_fine.Text = A1.Is_fine.ToString();        

            txtFine_rate.Text = A1.Fine_rate.ToString();

            txtFine_amt.Text = A1.Fine_amt.ToString();

            btnSubmit.Text = "Update";
            btnReset.Text = "Cancel";

            if (Request.QueryString["action"] == "del")
            {
                Label1.Text = "Are u Sure If U Want to Delete Record";
                txtBir_id.ReadOnly = false;
                ddlReg_id.Enabled = false;
                ddlMem_id.Enabled = false;
                ddlAcc_id.Enabled = false;
                txtIssue_dt.ReadOnly = false;
                txtIssue_days.ReadOnly = false;
                txtDue_dt.ReadOnly = false;
                txtReturn_dt.ReadOnly = false;
                txtDue_day.ReadOnly = false;
                DropDownList1.Enabled = false;
                DropDownList2.Enabled = false;
                txtFine_rate.ReadOnly = false;
                txtFine_amt.ReadOnly = false;
                btnSubmit.Text = "Delete";
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new Book_Issue_ReturnHandler();
            A1 = new Book_Issue_Return();


            //A1.Bir_id = Convert.ToInt32(txtBir_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);
            A1.Mem_id = Convert.ToInt32(ddlMem_id.SelectedValue);
            A1.Acc_id = Convert.ToInt32(ddlAcc_id.SelectedValue);
            A1.Issue_dt = Convert.ToDateTime(txtIssue_dt.Text);
            A1.Issue_days = Convert.ToInt32(txtIssue_days.Text);
            A1.Due_dt = Convert.ToDateTime(txtDue_dt.Text);
            A1.Return_dt = Convert.ToDateTime(txtReturn_dt.Text);
            A1.Due_day = Convert.ToInt32(txtDue_day.Text);
            if (DropDownList1.SelectedValue.ToString() == "1")
            {
                A1.Is_return = true;
            }
            else
            {
                A1.Is_return = false;
            }

            if (DropDownList2.SelectedValue.ToString() == "1")
            {
                A1.Is_fine = true;
            }
            else
            {
                A1.Is_fine = false;
            }
            //A1.Is_fine = Convert.ToBoolean(DropDownList2.SelectedValue.ToString());        
            //  A1.Fine_rate = Convert.ToDecimal(txtFine_rate.Text);        
            A1.Fine_amt = Convert.ToDecimal(txtFine_amt.Text);

            

            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewBook_Issue_Return(A1);
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
            else if (btnSubmit.Text == "Update")
            {
                A1.Bir_id = Convert.ToInt32(txtBir_id.Text);
                bool B = A_Handler.UpdateBook_Issue_Return(A1);
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
                A1.Bir_id = Convert.ToInt32(txtBir_id.Text);
                bool B = A_Handler.DeleteBook_Issue_Return(A1);
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

            // Response.Redirect("~/ADMIN/Book_Issue_Return_list.aspx?msg="+MSG);        
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text == "Cancel")
            {
                Response.Redirect("~/ADMIN/Book_Issue_Return_list.aspx");
            }
            else
            {
                txtBir_id.Text = "";
                ddlReg_id.SelectedIndex = -1;
                ddlMem_id.SelectedIndex = -1;
                ddlAcc_id.SelectedIndex = -1;
                txtIssue_dt.Text = "";
                txtIssue_days.Text = "";
                txtDue_dt.Text = "";
                txtReturn_dt.Text = "";
                txtDue_day.Text = "";
                //txtIs_return.Text = "";        
                DropDownList1.SelectedIndex = -1;
                DropDownList2.SelectedIndex = -1;
                txtFine_amt.Text = "";
                Label1.Text = "";
                btnSubmit.Text = "Submit";
            }
        }
    }
}



