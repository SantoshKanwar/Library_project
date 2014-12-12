
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
using E_Libpro.My_Function;

using AURO.BLL;
using AURO.DAL;
//using E_Libpro.My_Function;

namespace E_lib_pro1.LIBRARIAN
{
    public partial class WebForm1: System.Web.UI.Page
    {
        //MyClass my = new MyClass();
        AccessionHandler A_Handler = null;
        Accession A1 = null;
        string MSG;
        int cid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    A1 = new Accession();
                    int ID = Convert.ToInt32(Request.QueryString["id"]);
                    show_data(ID);
                }
                MyClass my = new MyClass();
                if (Session["College_id"] != null)
                {
                    cid = int.Parse(Session["College_id"].ToString());
                }
                //    Label2.Text = cid.ToString();
                //    Label3.Text = my.Get_College(cid);
                //}
                //my.FillCombo(ddlBook_id, "Book_Master", "Title", "book_id", "");
                //my.FillCombo(ddlCollege_id, "College", "College_Name", "College_id", "");
            }
        }

        public void show_data(int ID)
        {
            A_Handler = new AccessionHandler();
            A1 = new Accession();
            A1 = A_Handler.GetAccessionDetails(ID);


            txtAcc_id.Text = A1.Acc_id.ToString();

            ddlReg_id.SelectedValue = A1.Reg_id.ToString();

            ddlBook_id.SelectedValue = A1.Book_id.ToString();

            ddlCollege_id.SelectedValue = A1.College_id.ToString();

            txtAcc_code.Text = A1.Acc_code.ToString();

            txtLocation.Text = A1.Location.ToString();



            DropDownList1.SelectedValue = A1.Is_issue.ToString();

            DropDownList2.SelectedValue = A1.Status.ToString();

            btnSubmit.Text = "Update";
            btnReset.Text = "Cancel";

            if (Request.QueryString["action"] == "del")
            {


                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtAcc_id.ReadOnly = false;
                ddlReg_id.Enabled = false;
                ddlBook_id.Enabled = false;
                ddlCollege_id.Enabled = false;
                txtAcc_code.ReadOnly = false;
                txtLocation.ReadOnly = false;

                DropDownList1.Enabled = false;
                DropDownList2.Enabled = false;
                btnSubmit.Text = "Delete";
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new AccessionHandler();
            A1 = new Accession();


            //A1.Acc_id = Convert.ToInt32(txtAcc_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);
            A1.Book_id = Convert.ToInt32(ddlBook_id.SelectedValue);
            A1.College_id = Convert.ToInt32(ddlCollege_id.SelectedValue);
            A1.Acc_code = txtAcc_code.Text;
            A1.Location = txtLocation.Text;

            A1.Is_issue =Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            A1.Status = Convert.ToInt32(DropDownList2.SelectedValue.ToString());

            

            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewAccession(A1);
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
                A1.Acc_id = Convert.ToInt32(txtAcc_id.Text);
                bool B = A_Handler.UpdateAccession(A1);
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
                A1.Acc_id = Convert.ToInt32(txtAcc_id.Text);
                bool B = A_Handler.DeleteAccession(A1);
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

            //  Response.Redirect("~/ADMIN/Accession_list.aspx?msg="+MSG);        
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text == "Cancel")
            {
                Response.Redirect("~/LIBRARIAN/Accession_list.aspx");
            }
            else
            {
                txtAcc_id.Text = "";
                ddlReg_id.SelectedIndex = -1;
                ddlBook_id.SelectedIndex = -1;
                ddlCollege_id.SelectedIndex = -1;
                txtAcc_code.Text = "";
                txtLocation.Text = "";

                DropDownList1.SelectedIndex = -1;
                DropDownList2.SelectedIndex = -1;
                Label1.Text = "";
                btnSubmit.Text = "Submit";
            }
        }
    }
}



