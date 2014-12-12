        
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
    public partial class Composite_Dep_entry : System.Web.UI.Page
    {
        //MyClass my = new MyClass();   
        Composite_DepHandler A_Handler = null;        
        Composite_Dep A1 = null;
        string MSG;  
         protected void Page_Load(object sender, EventArgs e)        
        {        
            if (!IsPostBack)        
            {        
                if (Request.QueryString["id"] != null)        
                {                            
                    A1 = new Composite_Dep();        
                    int ID = Convert.ToInt32(Request.QueryString["id"]);        
                    show_data(ID);
                    
                }
                //my.FillCombo(ddlDep_id, "Department", "Dep_name", "Dep_id", "");
                //my.FillCombo(ddlCollege_id, "College", "College_Name", "College_id", "");
            }        
        }        
        
        public void show_data(int ID)        
        {        
            A_Handler = new Composite_DepHandler();        
            A1 = new Composite_Dep();        
            A1 = A_Handler.GetComposite_DepDetails(ID);        
                      
                
            txtComp_id.Text = A1.Comp_id.ToString();        
                
            ddlDep_id.SelectedValue = A1.Dep_id.ToString();        
                
            ddlCollege_id.SelectedValue = A1.College_id.ToString();        
                      
            btnSubmit.Text = "Update";        
            btnReset.Text = "Cancel";        
            
            if (Request.QueryString["action"] == "del")        
            {
               // Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtComp_id.ReadOnly = false;        
                ddlDep_id.Enabled = false;        
                ddlCollege_id.Enabled = false;        
                btnSubmit.Text = "Delete";                        
            }        
        
        }        
        protected void btnSubmit_Click(object sender, EventArgs e)        
        {        
            A_Handler = new Composite_DepHandler();        
            A1 = new Composite_Dep();        
        
        
            //A1.Comp_id = Convert.ToInt32(txtComp_id.Text);        
            A1.Dep_id = Convert.ToInt32(ddlDep_id.SelectedValue);        
            A1.College_id = Convert.ToInt32(ddlCollege_id.SelectedValue);        
        
                    
        
            if (btnSubmit.Text == "Submit")        
            {        
                bool B = A_Handler.AddNewComposite_Dep(A1);        
                if (B == true)        
                {        
                    Label1.Text = "Record Inserted";        
                   // MSG = "Record Inserted";         
                }        
                else        
                {        
                    Label1.Text = "Record Not Inserted";        
                   // MSG = "Record Not Inserted";         
                }        
            }        
            else if(btnSubmit.Text == "Update")        
            {        
                A1.Comp_id = Convert.ToInt32(txtComp_id.Text);        
                bool B = A_Handler.UpdateComposite_Dep(A1);        
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
                A1.Comp_id = Convert.ToInt32(txtComp_id.Text);        
                bool B = A_Handler.DeleteComposite_Dep(A1);        
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
        
            //Response.Redirect("~/ADMIN/Composite_Dep_list.aspx?msg="+MSG);        
        }        
        
        protected void btnReset_Click(object sender, EventArgs e)        
        {        
            if (btnReset.Text == "Cancel")        
            {        
                Response.Redirect("~/ADMIN/Composite_Dep_list.aspx");        
            }        
            else        
            {        
                txtComp_id.Text = "";        
                ddlDep_id.SelectedIndex = -1;        
                ddlCollege_id.SelectedIndex = -1;
                Label1.Text = "";
                btnSubmit.Text = "Submit";        
            }        
        }        
    }        
}        
        
        

