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

namespace E_lib_pro1.LIBRARIAN
{
    public partial class Book_Issue_entry: System.Web.UI.Page
    {


        Book_Issue_ReturnHandler A_Handler = null;
        Book_Issue_Return A1 = null;
        string MSG;
        static int cid = 0;
      
      

        public void show_Member(string MEM_CODE)
        {
            string sql = "select * from VMember where  COLLEGE_ID =" + cid + " and member_code = '" + MEM_CODE + "' ";
            DataTable dt = new DataTable();
            MyClass cs = new MyClass();
            dt = cs.GetTable(sql);

            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["Member_Name"].ToString();
                TextBox2.Text = dt.Rows[0]["Dep_name"].ToString();
                TextBox3.Text = dt.Rows[0]["College_Name"].ToString();

                lblMem_Id.Text = dt.Rows[0]["Mem_ID"].ToString();
                lblRole.Text = dt.Rows[0]["Role"].ToString();

                Image1.ImageUrl = "~/img/" + dt.Rows[0]["photo"].ToString();

                SqlDataSource3.SelectCommand = "SELECT Bir_id, Acc_code, Title, Author, Book_type, Issue_dt,due_dt, Photo FROM VBook_Issue_Return WHERE (Is_return = 0) AND (Mem_id = "+ lblMem_Id.Text +")";
                SqlDataSource3.DataBind();

            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";

                Image1.ImageUrl = "~/img/000.jpg";
            }
        }
       

        public void show_Accession(string ACC_CODE)
        {

            string sql = "select * from VAccession where COLLEGE_ID ="+cid+" and Acc_Code = '" + ACC_CODE +"' ";
            DataTable dt = new DataTable();
            MyClass cs = new MyClass();
            dt = cs.GetTable(sql);
            if (dt.Rows.Count > 0)
            {
                TextBox4.Text = dt.Rows[0]["Title"].ToString();
                TextBox5.Text = dt.Rows[0]["Author"].ToString();
                TextBox6.Text = dt.Rows[0]["Subject"].ToString();

                lblAcc_ID.Text = dt.Rows[0]["Acc_ID"].ToString();
                Image2.ImageUrl = "~/Book_Img/" + dt.Rows[0]["photo"].ToString();

            }
            else
            {
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            MyClass my = new MyClass();
            if (!IsPostBack)
            {
                TextBox7.Text = DateTime.Now.ToShortDateString();

                if (Session["College_id"] != null)
                {
                    cid = int.Parse(Session["College_id"].ToString());

                    lblcollegeid.Text = cid.ToString();
                    lblcollegename.Text = my.Get_College(cid);
                }



                if (Request.QueryString["did"] != null)
                {
                    int BIR_ID = Int32.Parse(Request.QueryString["did"].ToString());
                    string ss = "delete from Book_Issue_Return where Bir_id = " + BIR_ID;
                    my.Execute(ss);
                    //Label2.Text = ss.ToString();
                    Response.Redirect("~/LIBRARIAN/Book_Issue_entry.aspx");
                }



            }
        }

     
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (TextBox10.Text == "")
            {
                TextBox10.Text = "0";
            }
            int MyNo = Int32.Parse(TextBox10.Text);
            if (Gridview1.Rows.Count >= MyNo)
            {
                Button1.Visible = false;
                lblMax.Text = "Maximum Book Is Issuesed";
                return;
            }
            A_Handler = new Book_Issue_ReturnHandler();
            A1 = new Book_Issue_Return();

            
           // A1.Bir_id = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            A1.Reg_id =Int32.Parse(lblReg_ID.Text);
            A1.Mem_id = Convert.ToInt32(lblMem_Id.Text);
            A1.Acc_id = Convert.ToInt32(lblAcc_ID.Text);
          
            A1.Issue_dt = Convert.ToDateTime(TextBox7.Text);
            A1.Issue_days = Convert.ToInt32(TextBox8.Text);
            A1.Due_dt = A1.Issue_dt.AddDays(A1.Issue_days);
            A1.Return_dt = A1.Issue_dt;
            A1.Due_day = 0;
            A1.Is_return = false;
            A1.Is_fine = false;
            A1.Fine_amt = 0;

            bool b=A_Handler.AddNewBook_Issue_Return(A1);
            if (b == true)
            {
                 lblMax.Text="Book is Issued";
                //GridView1.DataBind();
            }


            SqlDataSource3.SelectCommand = "SELECT Bir_id, Acc_code, Title, Author, Book_type, Issue_dt,due_dt, Photo FROM VBook_Issue_Return WHERE (Is_return = 0) AND (Mem_id = " + lblMem_Id.Text + ")";
            SqlDataSource3.DataBind();
        }

       

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lblReg_ID.Text = Session["mem_id"].ToString();

            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }

            string mem_code = TextBox11.Text;
            show_Member(mem_code);


            //========== Show Setiing ===============
            string role = lblRole.Text;
            int col_id =Int32.Parse(lblcollegeid.Text);
            Show_Setting(role, col_id);

            if (TextBox10.Text == "")
            {
                TextBox10.Text = "0";
            }
            int MyNo = Int32.Parse(TextBox10.Text);
            if (Gridview1.Rows.Count >= MyNo)
            {
                Button1.Visible = false;
                lblMax.Text = "Maximum Book Is Issuesed";
            }
            else
            {
                Button1.Visible = true;
                lblMax.Text = "";
            }

            
        }

        public void Show_Setting(String ROLE,int COLLEGE_ID)
        {
            string sql = "select * from VSetting where Mem_Role='"+ ROLE +"' and college_id ="+ COLLEGE_ID +" ";
            DataTable dt = new DataTable();
            MyClass cs = new MyClass();
            dt = cs.GetTable(sql);
            if (dt.Rows.Count > 0)
            {
                TextBox8.Text = dt.Rows[0]["Due_Day"].ToString();

                DateTime Issue_dt = Convert.ToDateTime(TextBox7.Text);
                int Issue_days = Convert.ToInt32(TextBox8.Text);
                DateTime Due_dt = Issue_dt.AddDays(Issue_days);

                TextBox9.Text = Due_dt.ToShortDateString();
                TextBox10.Text = dt.Rows[0]["Total_Book"].ToString();
            }
            else
            {
                TextBox8.Text = "15";

                DateTime Issue_dt = Convert.ToDateTime(TextBox7.Text);
                int Issue_days = Convert.ToInt32(TextBox8.Text);
                DateTime Due_dt = Issue_dt.AddDays(Issue_days);

                TextBox9.Text = Due_dt.ToShortDateString();
                TextBox10.Text = "3";
            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string Acc_Code = TextBox12.Text;
            show_Accession(Acc_Code);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LIBRARIAN/Book_Issue_entry.aspx");
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Report/Rpt_Book_Issue.aspx");
        }

       

       

       

    
    }
}