        
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
    public partial class Composite1_Desig_entry : System.Web.UI.Page
    {
        //MyClass my = new MyClass(); 
        Composite1_DesigHandler A_Handler = null;        
        Composite1_Desig A1 = null;
        string MSG;  
         protected void Page_Load(object sender, EventArgs e)        
        {        
            if (!IsPostBack)        
            {        
                if (Request.QueryString["id"] != null)        
                {                            
                    A1 = new Composite1_Desig();        
                    int ID = Convert.ToInt32(Request.QueryString["id"]);        
                    show_data(ID);        
                }
                //my.FillCombo(ddlDes_id, "Designation", "Des_name", "Des_id", "");
                //my.FillCombo(ddlCollege_id, "College", "College_Name", "College_id", "");
            }        
        }        
        
        public void show_data(int ID)        
        {        
            A_Handler = new Composite1_DesigHandler();        
            A1 = new Composite1_Desig();        
            A1 = A_Handler.GetComposite1_DesigDetails(ID);        
                      
                
            txtComp1_id.Text = A1.Comp1_id.ToString();        
                
            ddlDes_id.Text = A1.Des_id.ToString();        
                
            ddlCollege_id.Text = A1.College_id.ToString();        
                      
            btnSubmit.Text = "Update";        
            btnReset.Text = "Cancel";        
            
            if (Request.QueryString["action"] == "del")        
            {

                Label1.Text = "Are u Sure If U Want to Delete Record";
                txtComp1_id.ReadOnly = false;        
                ddlDes_id.Enabled = false;        
                ddlCollege_id.Enabled = false;        
                btnSubmit.Text = "Delete";                        
            }        
        
        }        
        protected void btnSubmit_Click(object sender, EventArgs e)        
        {        
            A_Handler = new Composite1_DesigHandler();        
            A1 = new Composite1_Desig();        
        
        
            //A1.Comp1_id = Convert.ToInt32(txtComp1_id.Text);        
            A1.Des_id = Convert.ToInt32(ddlDes_id.SelectedValue);        
            A1.College_id = Convert.ToInt32(ddlCollege_id.SelectedValue);        
        
                    
        
            if (btnSubmit.Text == "Submit")        
            {        
                bool B = A_Handler.AddNewComposite1_Desig(A1);        
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
                A1.Comp1_id = Convert.ToInt32(txtComp1_id.Text);        
                bool B = A_Handler.UpdateComposite1_Desig(A1);        
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
                A1.Comp1_id = Convert.ToInt32(txtComp1_id.Text);        
                bool B = A_Handler.DeleteComposite1_Desig(A1);        
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
        
           // Response.Redirect("~/ADMIN/Composite1_Desig_list.aspx?msg="+MSG);        
        }        
        
        protected void btnReset_Click(object sender, EventArgs e)        
        {        
            if (btnReset.Text == "Cancel")        
            {        
                Response.Redirect("~/ADMIN/Composite1_Desig_list.aspx");        
            }        
            else        
            {        
                txtComp1_id.Text = "";        
                ddlDes_id.SelectedIndex = -1;        
                ddlCollege_id.SelectedIndex = -1;
                Label1.Text = "";
                btnSubmit.Text = "Submit";        
            }        
        }        
    }        
}        
        
        

