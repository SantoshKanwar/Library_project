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
    public partial class WebForm5 : System.Web.UI.Page
    {
        Book_MasterHandler A_Handler = null;
        Book_Master A1 = null;
        string MSG;  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    A1 = new Book_Master();
                    int ID = Convert.ToInt32(Request.QueryString["id"]);
                    show_data(ID);
                }
            }
        }

        public void show_data(int ID)
        {
            A_Handler = new Book_MasterHandler();
            A1 = new Book_Master();
            A1 = A_Handler.GetBook_MasterDetails(ID);


            txtBook_id.Text = A1.Book_id.ToString();

            ddlReg_id.Text = A1.Reg_id.ToString();

            txtPdate.Text = A1.Pdate.ToString();

            txtAuthor.Text = A1.Author.ToString();

            txtTitle.Text = A1.Title.ToString();

            txtSubject.Text = A1.Subject.ToString();

            DropDownList1.Text = A1.Book_type.ToString();

            txtEdition.Text = A1.Edition.ToString();

            txtPublisher_place.Text = A1.Publisher_place.ToString();

            txtPublisher.Text = A1.Publisher.ToString();

            txtYear.Text = A1.Year.ToString();

            txtPages.Text = A1.Pages.ToString();

            txtVolume.Text = A1.Volume.ToString();

            txtSource.Text = A1.Source.ToString();

            txtCost.Text = A1.Cost.ToString();

            txtBill_no.Text = A1.Bill_no.ToString();

            txtBook_no.Text = A1.Book_no.ToString();

            txtMore_info.Text = A1.More_info.ToString();

            // txtPhoto.Text = A1.Photo.ToString();        
            if (A1.Photo.ToString() != null)
            {
                Image1.ImageUrl = ("~/img/" + A1.Photo.ToString()); ;
            }
            else
            {
                Image1.ImageUrl = ("~/img/000.jpg");
            }
            btnSubmit.Text = "Update";
            btnReset.Text = "Cancel";

            if (Request.QueryString["action"] == "del")
            {
                Label1.Text = "Are U Sure, U want to  Delete a Record ?";
                txtBook_id.ReadOnly = false;
                ddlReg_id.Enabled = false;
                txtPdate.ReadOnly = true;
                txtAuthor.ReadOnly = false;
                txtTitle.ReadOnly = false;
                txtSubject.ReadOnly = false;
                DropDownList1.Enabled = false;
                txtEdition.ReadOnly = false;
                txtPublisher_place.ReadOnly = false;
                txtPublisher.ReadOnly = false;
                txtYear.ReadOnly = false;
                txtPages.ReadOnly = false;
                txtVolume.ReadOnly = false;
                txtSource.ReadOnly = false;
                txtCost.ReadOnly = false;
                txtBill_no.ReadOnly = false;
                txtBook_no.ReadOnly = false;
                txtMore_info.ReadOnly = false;
                FileUpload1.Enabled = false;
                btnSubmit.Text = "Delete";
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new Book_MasterHandler();
            A1 = new Book_Master();


            //A1.Book_id = Convert.ToInt32(txtBook_id.Text);        
            A1.Reg_id = Convert.ToInt32(ddlReg_id.SelectedValue);
            A1.Pdate = Convert.ToDateTime(txtPdate.Text);
            A1.Author = txtAuthor.Text;
            A1.Title = txtTitle.Text;
            A1.Subject = txtSubject.Text;
            A1.Book_type = DropDownList1.Text;
            A1.Edition = txtEdition.Text;
            A1.Publisher_place = txtPublisher_place.Text;
            A1.Publisher = txtPublisher.Text;
            A1.Year = Convert.ToInt32(txtYear.Text);
            A1.Pages = Convert.ToInt32(txtPages.Text);
            A1.Volume = txtVolume.Text;
            A1.Source = txtSource.Text;
            A1.Cost = Convert.ToDecimal(txtCost.Text);
            A1.Bill_no = Convert.ToInt32(txtBill_no.Text);
            A1.Book_no = Convert.ToInt32(txtBook_no.Text);
            A1.More_info = txtMore_info.Text;
            //  A1.Photo = txtPhoto.Text;        
            A1.Photo = "000.jpg";

            if (FileUpload1.HasFile == true)
            {
                FileUpload1.SaveAs(Server.MapPath("~/img") + "/" + FileUpload1.FileName);

                A1.Photo = FileUpload1.FileName;
            }
            

            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewBook_Master(A1);
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
                A1.Book_id = Convert.ToInt32(txtBook_id.Text);
                bool B = A_Handler.UpdateBook_Master(A1);
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
                A1.Book_id = Convert.ToInt32(txtBook_id.Text);
                bool B = A_Handler.DeleteBook_Master(A1);
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

            //Response.Redirect("~/ADMIN/Book_Master_list.aspx?msg="+MSG);        
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text == "Cancel")
            {
                Response.Redirect("~/LIBRARIAN/Book_Master_list.aspx");
            }
            else
            {
                txtBook_id.Text = "";
                ddlReg_id.SelectedIndex = -1;
                txtPdate.Text = "";
                txtAuthor.Text = "";
                txtTitle.Text = "";
                txtSubject.Text = "";
                DropDownList1.SelectedIndex = -1;
                txtEdition.Text = "";
                txtPublisher_place.Text = "";
                txtPublisher.Text = "";
                txtYear.Text = "";
                txtPages.Text = "";
                txtVolume.Text = "";
                txtSource.Text = "";
                txtCost.Text = "";
                txtBill_no.Text = "";
                txtBook_no.Text = "";
                txtMore_info.Text = "";
                // txtPhoto.Text = "";        
                Label1.Text = "";
                btnSubmit.Text = "Submit";
            }
        }
    }
}