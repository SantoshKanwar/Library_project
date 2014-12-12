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
namespace E_lib_pro1.LIBRARIAN
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        //MyClass my = new MyClass();
        FineHandler A_Handler = null;
        Fine A1 = null;
        string MSG;  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    A1 = new Fine();
                    int ID = Convert.ToInt32(Request.QueryString["id"]);
                    show_data(ID);
                }
                //my.FillCombo(ddlMem_id, "Member", "Member_code", "Mem_id", "");
            }
        }

        public void show_data(int ID)
        {
            A_Handler = new FineHandler();
            A1 = new Fine();
            A1 = A_Handler.GetFineDetails(ID);


            txtFine_id.Text = A1.Fine_id.ToString();

            ddlReg_id.Text = A1.Reg_id.ToString();

            txtRec_no.Text = A1.Rec_no.ToString();

            txtFine_date.Text = A1.Fine_date.ToString();

            ddlMem_id.Text = A1.Mem_id.ToString();

            txtFine_amt.Text = A1.Fine_amt.ToString();

            txtRec_amt.Text = A1.Rec_amt.ToString();

            txtDetail.Text = A1.Detail.ToString();

            txtRec_by.Text = A1.Rec_by.ToString();

            btnSubmit.Text = "Update";
            btnReset.Text = "Cancel";

            if (Request.QueryString["action"] == "del")
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtFine_id.ReadOnly = false;
                ddlReg_id.Enabled = false;
                txtRec_no.ReadOnly = false;
                txtFine_date.ReadOnly = false;
                ddlMem_id.Enabled = false;
                txtFine_amt.ReadOnly = false;
                txtRec_amt.ReadOnly = false;
                txtDetail.ReadOnly = false;
                txtRec_by.ReadOnly = false;
                btnSubmit.Text = "Delete";
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new FineHandler();
            A1 = new Fine();


            //A1.Fine_id = Convert.ToInt32(txtFine_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);
            A1.Rec_no = Convert.ToInt32(txtRec_no.Text);
            A1.Fine_date = Convert.ToDateTime(txtFine_date.Text);
            A1.Mem_id = Convert.ToInt32(ddlMem_id.SelectedValue);
            A1.Fine_amt = Convert.ToDecimal(txtFine_amt.Text);
            A1.Rec_amt = Convert.ToDecimal(txtRec_amt.Text);
            A1.Detail = txtDetail.Text;
            A1.Rec_by = Convert.ToInt32(txtRec_by.Text);

            

            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewFine(A1);
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
                A1.Fine_id = Convert.ToInt32(txtFine_id.Text);
                bool B = A_Handler.UpdateFine(A1);
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
                A1.Fine_id = Convert.ToInt32(txtFine_id.Text);
                bool B = A_Handler.DeleteFine(A1);
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

            //Response.Redirect("~/ADMIN/Fine_list.aspx?msg="+MSG);        
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text == "Cancel")
            {
                Response.Redirect("~/LIBRARIAN/Fine_list.aspx");
            }
            else
            {
                txtFine_id.Text = "";
                ddlReg_id.SelectedIndex = -1;
                txtRec_no.Text = "";
                txtFine_date.Text = "";
                ddlMem_id.SelectedIndex = -1;
                txtFine_amt.Text = "";
                txtRec_amt.Text = "";
                txtDetail.Text = "";
                txtRec_by.Text = "";
                Label1.Text = "";
                btnSubmit.Text = "Submit";
            }
        }
    }
}