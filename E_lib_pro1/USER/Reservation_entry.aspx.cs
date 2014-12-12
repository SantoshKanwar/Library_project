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

namespace E_lib_pro1.USER
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        ReservationHandler A_Handler = null;
        Reservation A1 = null;
        string MSG;  

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mem_id"] != null)
            {
                Label2.Text = Session["mem_id"].ToString();
            }
            else
            {
                Label2.Text = "1";
            }

            
        }

     
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            A_Handler = new ReservationHandler();
            A1 = new Reservation();


            //A1.Res_id = Convert.ToInt32(txtRes_id.Text);        
            A1.Reg_id = 1;
            A1.Res_date = DateTime.Now;
            A1.Book_title = txtBook_title.Text;
            A1.Book_author = txtBook_author.Text;
            A1.Book_publisher = txtBook_publisher.Text;
            A1.Mem_id = Convert.ToInt32(Label2.Text);
            A1.Status = 1;

            

            if (btnSubmit.Text == "Submit")
            {
                bool B = A_Handler.AddNewReservation(A1);
                if (B == true)
                {
                    Label1.Text = "Your Reservation Successfully";
                    MSG = "Your Reservation Successfully";
                }
                else
                {
                    Label1.Text = "Your Reservation Not Successfully";
                    MSG = "Your Reservation Not Successfully";
                }
            }
            

            //Response.Redirect("~/ADMIN/Reservation_list.aspx?msg="+MSG);        
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
             txtBook_title.Text = "";
                txtBook_author.Text = "";
                txtBook_publisher.Text = "";
                
                Label1.Text = "";
                btnSubmit.Text = "Submit";
            
        }
    }
}



