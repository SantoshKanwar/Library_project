        
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
     //using E_Libpro.My_Function;   
namespace AURO.ADMIN        
{        
    public partial class Order_Detail_entry : System.Web.UI.Page
    {
        //MyClass my = new MyClass();
        Order_DetailHandler A_Handler = null;        
        Order_Detail A1 = null;
        string MSG;  
         protected void Page_Load(object sender, EventArgs e)        
        {        
            if (!IsPostBack)        
            {        
                if (Request.QueryString["id"] != null)        
                {                            
                    A1 = new Order_Detail();        
                    int ID = Convert.ToInt32(Request.QueryString["id"]);        
                    show_data(ID);        
                }
                //my.FillCombo(ddlBook_id, "Book_Master", "Title", "Book_id", "");
               
            }        
        }        
        
        public void show_data(int ID)        
        {        
            A_Handler = new Order_DetailHandler();        
            A1 = new Order_Detail();        
            A1 = A_Handler.GetOrder_DetailDetails(ID);        
                      
                
            txtOd_id.Text = A1.Od_id.ToString();        
                
            ddlReg_id.Text = A1.Reg_id.ToString();        
                
            ddlOm_id.Text = A1.Om_id.ToString();        
                
            ddlBook_id.Text = A1.Book_id.ToString();


            txtQty.Text = A1.Qty.ToString();

            txtRate.Text = A1.Rate.ToString();

            txtAmount.Text = A1.Amount.ToString();        
                      
            btnSubmit.Text = "Update";        
            btnReset.Text = "Cancel";        
            
            if (Request.QueryString["action"] == "del")        
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtOd_id.ReadOnly = false;        
                ddlReg_id.Enabled = false;        
                ddlOm_id.Enabled = false;        
                ddlBook_id.Enabled = false;        
                txtQty.ReadOnly = false;        
                txtRate.ReadOnly = false;        
                txtAmount.ReadOnly = false;        
                btnSubmit.Text = "Delete";                        
            }        
        
        }        
        protected void btnSubmit_Click(object sender, EventArgs e)        
        {        
            A_Handler = new Order_DetailHandler();        
            A1 = new Order_Detail();        
        
        
            //A1.Od_id = Convert.ToInt32(txtOd_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);        
            A1.Om_id = Convert.ToInt32(ddlOm_id.SelectedValue);        
            A1.Book_id = Convert.ToInt32(ddlBook_id.SelectedValue);        
            A1.Qty = Convert.ToInt32(txtQty.Text);        
            A1.Rate = Convert.ToDecimal(txtRate.Text);        
            A1.Amount = Convert.ToDecimal(txtAmount.Text);        
        
                 
        
            if (btnSubmit.Text == "Submit")        
            {        
                bool B = A_Handler.AddNewOrder_Detail(A1);        
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
                A1.Od_id = Convert.ToInt32(txtOd_id.Text);        
                bool B = A_Handler.UpdateOrder_Detail(A1);        
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
                A1.Od_id = Convert.ToInt32(txtOd_id.Text);        
                bool B = A_Handler.DeleteOrder_Detail(A1);        
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
        
            //Response.Redirect("~/ADMIN/Order_Detail_list.aspx?msg="+MSG);        
        }        
        
        protected void btnReset_Click(object sender, EventArgs e)        
        {        
            if (btnReset.Text == "Cancel")        
            {        
                Response.Redirect("~/ADMIN/Order_Detail_list.aspx");        
            }        
            else        
            {        
                txtOd_id.Text = "";        
                ddlReg_id.SelectedIndex = -1;        
                ddlOm_id.SelectedIndex = -1;        
                ddlBook_id.SelectedIndex = -1;        
                txtQty.Text = "";        
                txtRate.Text = "";        
                txtAmount.Text = "";
                Label1.Text = "";
                btnSubmit.Text = "Submit";        
            }        
        }        
    }        
}        
        
        

