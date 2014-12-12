
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
    public partial class WebForm19 : System.Web.UI.Page
    {
        //MyClass my = new MyClass();
        Purchase_DetailHandler A_Handler = null;
        Purchase_Detail A1 = null;
        string MSG;  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    A1 = new Purchase_Detail();
                    int ID = Convert.ToInt32(Request.QueryString["id"]);
                    show_data(ID);
                }
                //my.FillCombo(ddlBook_id, "Book_Master", "Title", "Book_id", "");
            }
        }

        public void show_data(int ID)
        {
            A_Handler = new Purchase_DetailHandler();
            A1 = new Purchase_Detail();
            A1 = A_Handler.GetPurchase_DetailDetails(ID);


            txtPd_id.Text = A1.Pd_id.ToString();

            ddlReg_id.SelectedValue = A1.Reg_id.ToString();

            ddlPm_id.SelectedValue = A1.Pm_id.ToString();

            ddlBook_id.SelectedValue = A1.Book_id.ToString();

            txtQty.Text = A1.Qty.ToString();

            txtRate.Text = A1.Rate.ToString();

            txtAmount.Text = A1.Amount.ToString();

            btnSubmit.Text = "Update";
            btnReset.Text = "Cancel";

            if (Request.QueryString["action"] == "del")
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtPd_id.ReadOnly = false;
                ddlReg_id.Enabled = false;
                ddlPm_id.Enabled = false;
                ddlBook_id.Enabled = false;
                txtQty.ReadOnly = false;
                txtRate.ReadOnly = false;
                txtAmount.ReadOnly = false;
                btnSubmit.Text = "Delete";
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new Purchase_DetailHandler();
            A1 = new Purchase_Detail();


            //A1.Pd_id = Convert.ToInt32(txtPd_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);
            A1.Pm_id = Convert.ToInt32(ddlPm_id.SelectedValue);
            A1.Book_id = Convert.ToInt32(ddlBook_id.SelectedValue);

            A1.Qty = Convert.ToInt32(txtQty.Text);
            A1.Rate = Convert.ToDecimal(txtRate.Text);
            A1.Amount = Convert.ToDecimal(txtAmount.Text);

          

            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewPurchase_Detail(A1);
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
                A1.Pd_id = Convert.ToInt32(txtPd_id.Text);
                bool B = A_Handler.UpdatePurchase_Detail(A1);
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
                A1.Pd_id = Convert.ToInt32(txtPd_id.Text);
                bool B = A_Handler.DeletePurchase_Detail(A1);
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
            
            //Response.Redirect("~/ADMIN/Purchase_Detail_list.aspx?msg="+MSG);        
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text == "Cancel")
            {
                Response.Redirect("~/LIBRARIAN/Purchase_Detail_list.aspx");
            }
            else
            {
                txtPd_id.Text = "";
                ddlReg_id.SelectedIndex = -1;
                ddlPm_id.SelectedIndex = -1;
                ddlBook_id.SelectedIndex = -1;
                txtQty.Text = "";
                txtRate.Text = "";
                txtAmount.Text = "";
                Label1.Text = "";
                btnSubmit.Text = "Submit";
            }
        }

       

        protected void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        public void Get_Calculation()
        {
            try
            {
                int qty = Int32.Parse(txtQty.Text);
                decimal rate = Decimal.Parse(txtRate.Text);

                Decimal tot_Amt = qty * rate;
                txtAmount.Text = tot_Amt.ToString();
            }
            catch { }

        }

        protected void txtQty_TextChanged(object sender, EventArgs e)
        {
            Get_Calculation();
        }

        protected void txtRate_TextChanged(object sender, EventArgs e)
        {
            Get_Calculation();
        }

        

        
    }
}