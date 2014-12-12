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
    public partial class WebForm21 : System.Web.UI.Page
    {

        Purchase_MasterHandler A_Handler = null;
        Purchase_Master A1 = null;
        string MSG;  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    A1 = new Purchase_Master();
                    int ID = Convert.ToInt32(Request.QueryString["id"]);
                    show_data(ID);
                }
            }
        }

        public void show_data(int ID)
        {
            A_Handler = new Purchase_MasterHandler();
            A1 = new Purchase_Master();
            A1 = A_Handler.GetPurchase_MasterDetails(ID);


            txtPm_id.Text = A1.Pm_id.ToString();

            ddlReg_id.Text = A1.Reg_id.ToString();

            ddlMem_id.Text = A1.Mem_id.ToString();

            txtPm_Number.Text = A1.Pm_Number.ToString();

            txtPm_Date.Text = A1.Pm_Date.ToString();

            txtPur_bill_no.Text = A1.Pur_bill_no.ToString();

            txtPur_date.Text = A1.Pur_date.ToString();

            txtSup_name.Text = A1.Sup_name.ToString();

            txtSup_address.Text = A1.Sup_address.ToString();

            txtSup_City.Text = A1.Sup_City.ToString();

            txtSup_mobile.Text = A1.Sup_mobile.ToString();

            txtSup_email.Text = A1.Sup_email.ToString();

            txtGross_amt.Text = A1.Gross_amt.ToString();

            txtDis_amt.Text = A1.Dis_amt.ToString();

            txtNet_amt.Text = A1.Net_amt.ToString();

            ddlPaid.Text = A1.Is_paid.ToString();

            txtUser1.Text = A1.User1.ToString();

            ddlStatus.Text = A1.Status.ToString();

            btnSubmit.Text = "Update";
            btnReset.Text = "Cancel";

            if (Request.QueryString["action"] == "del")
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtPm_id.ReadOnly = false;
                ddlReg_id.Enabled = false;
                ddlMem_id.Enabled = false;
                txtPm_Number.ReadOnly = false;
                txtPm_Date.ReadOnly = false;
                txtPur_bill_no.ReadOnly = false;
                txtPur_date.ReadOnly = false;
                txtSup_name.ReadOnly = false;
                txtSup_address.ReadOnly = false;
                txtSup_City.ReadOnly = false;
                txtSup_mobile.ReadOnly = false;
                txtSup_email.ReadOnly = false;
                txtGross_amt.ReadOnly = false;
                txtDis_amt.ReadOnly = false;
                txtNet_amt.ReadOnly = false;
                ddlPaid.Enabled = false;
                txtUser1.ReadOnly = false;
                ddlStatus.Enabled = false;
                btnSubmit.Text = "Delete";
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new Purchase_MasterHandler();
            A1 = new Purchase_Master();


            //A1.Pm_id = Convert.ToInt32(txtPm_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);
            A1.Mem_id = Convert.ToInt32(ddlMem_id.SelectedValue);
            A1.Pm_Number = Convert.ToInt32(txtPm_Number.Text);
            A1.Pm_Date = Convert.ToDateTime(txtPm_Date.Text);
            A1.Pur_bill_no = Convert.ToInt32(txtPur_bill_no.Text);
            A1.Pur_date = Convert.ToDateTime(txtPur_date.Text);
            A1.Sup_name = txtSup_name.Text;
            A1.Sup_address = txtSup_address.Text;
            A1.Sup_City = txtSup_City.Text;
            A1.Sup_mobile = Convert.ToDecimal(txtSup_mobile.Text);
            A1.Sup_email = txtSup_email.Text;
            A1.Gross_amt = Convert.ToDecimal(txtGross_amt.Text);
            A1.Dis_amt = Convert.ToDecimal(txtDis_amt.Text);
            A1.Net_amt = Convert.ToDecimal(txtNet_amt.Text);
            A1.Is_paid = ddlPaid.Text;
            A1.User1 = txtUser1.Text;
            A1.Status = Convert.ToInt32(ddlStatus.Text);

            

            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewPurchase_Master(A1);
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
                A1.Pm_id = Convert.ToInt32(txtPm_id.Text);
                bool B = A_Handler.UpdatePurchase_Master(A1);
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
                A1.Pm_id = Convert.ToInt32(txtPm_id.Text);
                bool B = A_Handler.DeletePurchase_Master(A1);
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

            //Response.Redirect("~/ADMIN/Purchase_Master_list.aspx?msg="+MSG);        
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text == "Cancel")
            {
                Response.Redirect("~/LIBRARIAN/Purchase_Master_list.aspx");
            }
            else
            {
                txtPm_id.Text = "";
                ddlReg_id.SelectedIndex = -1;
                ddlMem_id.SelectedIndex = -1;
                txtPm_Number.Text = "";
                txtPm_Date.Text = "";
                txtPur_bill_no.Text = "";
                txtPur_date.Text = "";
                txtSup_name.Text = "";
                txtSup_address.Text = "";
                txtSup_City.Text = "";
                txtSup_mobile.Text = "";
                txtSup_email.Text = "";
                txtGross_amt.Text = "";
                txtDis_amt.Text = "";
                txtNet_amt.Text = "";
                ddlPaid.SelectedIndex = -1;
                txtUser1.Text = "";
                ddlStatus.SelectedIndex = -1;
                Label1.Text = "";
                btnSubmit.Text = "Submit";
            }
        }
    }
}