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
    public partial class WebForm13 : System.Web.UI.Page
    {
        NewsHandler A_Handler = null;
        News A1 = null;
        string MSG;  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    A1 = new News();
                    int ID = Convert.ToInt32(Request.QueryString["id"]);
                    show_data(ID);
                }
            }
        }

        public void show_data(int ID)
        {
            A_Handler = new NewsHandler();
            A1 = new News();
            A1 = A_Handler.GetNewsDetails(ID);


            txtNews_id.Text = A1.News_id.ToString();

            ddlReg_id.Text = A1.Reg_id.ToString();

            txtNews_date.Text = A1.News_date.ToString();

            txtTitle.Text = A1.Title.ToString();

            txtDetail.Text = A1.Detail.ToString();

            DropDownList1.SelectedValue = A1.Status.ToString();

            btnSubmit.Text = "Update";
            btnReset.Text = "Cancel";

            if (Request.QueryString["action"] == "del")
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtNews_id.ReadOnly = false;
                ddlReg_id.Enabled = false;
                txtNews_date.ReadOnly = false;
                txtTitle.ReadOnly = false;
                txtDetail.ReadOnly = false;
                DropDownList1.Enabled = false;
                btnSubmit.Text = "Delete";
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new NewsHandler();
            A1 = new News();


            //A1.News_id = Convert.ToInt32(txtNews_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);
            A1.News_date = Convert.ToDateTime(txtNews_date.Text);
            A1.Title = txtTitle.Text;
            A1.Detail = txtDetail.Text;
            A1.Status = Convert.ToInt32(DropDownList1.SelectedValue);

          

            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewNews(A1);
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
                A1.News_id = Convert.ToInt32(txtNews_id.Text);
                bool B = A_Handler.UpdateNews(A1);
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
                A1.News_id = Convert.ToInt32(txtNews_id.Text);
                bool B = A_Handler.DeleteNews(A1);
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

            //Response.Redirect("~/ADMIN/News_list.aspx?msg="+MSG);        
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text == "Cancel")
            {
                Response.Redirect("~/ADMIN/News_list.aspx");
            }
            else
            {
                txtNews_id.Text = "";
                ddlReg_id.SelectedIndex = -1;
                txtNews_date.Text = "";
                txtTitle.Text = "";
                txtDetail.Text = "";
                DropDownList1.SelectedValue = "";
                Label1.Text = "";
                btnSubmit.Text = "Submit";
            }
        }
    }
}
