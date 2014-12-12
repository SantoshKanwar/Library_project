
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
    public partial class Setting_entry : System.Web.UI.Page
    {
        //MyClass my = new MyClass();
        SettingHandler A_Handler = null;
        Setting A1 = null;
        string MSG;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    A1 = new Setting();
                    int ID = Convert.ToInt32(Request.QueryString["id"]);
                    show_data(ID);
                }
                //my.FillCombo(ddlCollege_id, "College", "College_Name", "College_id", "");
            }
        }

        public void show_data(int ID)
        {
            A_Handler = new SettingHandler();
            A1 = new Setting();
            A1 = A_Handler.GetSettingDetails(ID);


            txtSet_id.Text = A1.Set_id.ToString();

            ddlReg_id.Text = A1.Reg_id.ToString();

            ddlCollege_id.Text = A1.College_id.ToString();

            DropDownList1.Text = A1.Mem_role.ToString();

            txtDue_day.Text = A1.Due_day.ToString();

            txtTotal_book.Text = A1.Total_book.ToString();

            txtFine_per_day.Text = A1.Fine_per_day.ToString();

            btnSubmit.Text = "Update";
            btnReset.Text = "Cancel";

            if (Request.QueryString["action"] == "del")
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtSet_id.ReadOnly = false;
                ddlReg_id.Enabled = false;
                ddlCollege_id.Enabled = false;
                DropDownList1.Enabled = false;
                txtDue_day.ReadOnly = false;
                txtTotal_book.ReadOnly = false;
                txtFine_per_day.ReadOnly = false;
                btnSubmit.Text = "Delete";
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new SettingHandler();
            A1 = new Setting();


            //A1.Set_id = Convert.ToInt32(txtSet_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);
            A1.College_id = Convert.ToInt32(ddlCollege_id.SelectedValue);
            A1.Mem_role = DropDownList1.Text;
            A1.Due_day = Convert.ToInt32(txtDue_day.Text);
            A1.Total_book = Convert.ToInt32(txtTotal_book.Text);
            A1.Fine_per_day = Convert.ToDecimal(txtFine_per_day.Text);



            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewSetting(A1);
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
                A1.Set_id = Convert.ToInt32(txtSet_id.Text);
                bool B = A_Handler.UpdateSetting(A1);
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
                A1.Set_id = Convert.ToInt32(txtSet_id.Text);
                bool B = A_Handler.DeleteSetting(A1);
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

            //Response.Redirect("~/ADMIN/Setting_list.aspx?msg=" + MSG);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text == "Cancel")
            {
                Response.Redirect("~/LIBRARIAN/Setting_list.aspx");
            }
            else
            {
                txtSet_id.Text = "";
                ddlReg_id.SelectedIndex = -1;
                ddlCollege_id.SelectedIndex = -1;
                DropDownList1.SelectedIndex = -1;
                txtDue_day.Text = "";
                txtTotal_book.Text = "";
                txtFine_per_day.Text = "";
                Label1.Text = "";
                btnSubmit.Text = "Submit";
            }
        }
    }
}

