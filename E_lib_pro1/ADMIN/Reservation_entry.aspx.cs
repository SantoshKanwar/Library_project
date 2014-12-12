        
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
    public partial class Reservation_entry : System.Web.UI.Page
    {
        //MyClass my = new MyClass();
        ReservationHandler A_Handler = null;        
        Reservation A1 = null;
        string MSG;  
         protected void Page_Load(object sender, EventArgs e)        
        {        
            if (!IsPostBack)        
            {        
                if (Request.QueryString["id"] != null)        
                {                            
                    A1 = new Reservation();        
                    int ID = Convert.ToInt32(Request.QueryString["id"]);        
                    show_data(ID);        
                }
                //my.FillCombo(ddlMem_id, "Member", "Member_code", "Mem_id", "");
            }        
        }        
        
        public void show_data(int ID)        
        {        
            A_Handler = new ReservationHandler();        
            A1 = new Reservation();        
            A1 = A_Handler.GetReservationDetails(ID);        
                      
                
            txtRes_id.Text = A1.Res_id.ToString();        
                
            ddlReg_id.Text = A1.Reg_id.ToString();        
                
            txtRes_date.Text = A1.Res_date.ToString();        
                
            txtBook_title.Text = A1.Book_title.ToString();        
                
            txtBook_author.Text = A1.Book_author.ToString();        
                
            txtBook_publisher.Text = A1.Book_publisher.ToString();        
                
            ddlMem_id.Text = A1.Mem_id.ToString();        
                
           DropDownList1.SelectedValue= A1.Status.ToString();        
                      
            btnSubmit.Text = "Update";        
            btnReset.Text = "Cancel";        
            
            if (Request.QueryString["action"] == "del")        
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtRes_id.ReadOnly = true;        
                ddlReg_id.Enabled = false;        
                txtRes_date.ReadOnly = false;        
                txtBook_title.ReadOnly = false;        
                txtBook_author.ReadOnly = false;        
                txtBook_publisher.ReadOnly = false;        
                ddlMem_id.Enabled = false;        
                DropDownList1.Enabled=false;        
                btnSubmit.Text = "Delete";                        
            }        
        
        }        
        protected void btnSubmit_Click(object sender, EventArgs e)        
        {        
            A_Handler = new ReservationHandler();        
            A1 = new Reservation();        
        
        
            //A1.Res_id = Convert.ToInt32(txtRes_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);        
            A1.Res_date = Convert.ToDateTime(txtRes_date.Text);        
            A1.Book_title = txtBook_title.Text;        
            A1.Book_author = txtBook_author.Text;        
            A1.Book_publisher = txtBook_publisher.Text;        
            A1.Mem_id = Convert.ToInt32(ddlMem_id.SelectedValue);        
            A1.Status = Convert.ToInt32(DropDownList1.SelectedValue);        
        
                
        
            if (btnSubmit.Text == "Submit")        
            {        
                bool B = A_Handler.AddNewReservation(A1);        
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
                A1.Res_id = Convert.ToInt32(txtRes_id.Text);        
                bool B = A_Handler.UpdateReservation(A1);        
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
                A1.Res_id = Convert.ToInt32(txtRes_id.Text);        
                bool B = A_Handler.DeleteReservation(A1);        
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
        
            //Response.Redirect("~/ADMIN/Reservation_list.aspx?msg="+MSG);        
        }        
        
        protected void btnReset_Click(object sender, EventArgs e)        
        {        
            if (btnReset.Text == "Cancel")        
            {        
                Response.Redirect("~/ADMIN/Reservation_list.aspx");        
            }        
            else        
            {        
                txtRes_id.Text = "";        
                ddlReg_id.SelectedIndex = -1;        
                txtRes_date.Text = "";        
                txtBook_title.Text = "";        
                txtBook_author.Text = "";        
                txtBook_publisher.Text = "";        
                ddlMem_id.SelectedIndex = -1;        
                DropDownList1.SelectedIndex = -1;
                Label1.Text = "";
                btnSubmit.Text = "Submit";        
            }        
        }        
    }        
}        
        
        

