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
    public partial class Book_Return_entry : System.Web.UI.Page
    {

        Book_Issue_ReturnHandler A_Handler = null;
        Book_Issue_Return A1 = null;
        SqlDataAdapter dap=new SqlDataAdapter();

        string str=@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True";
        //string MSG;  
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            MyClass my = new MyClass();

            if (Session["user"] != null)
            {
                lblReg_ID.Text = Session["mem_id"].ToString();
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }


            if (Session["College_id"] != null)
            {
                int cid = int.Parse(Session["College_id"].ToString());

                lblCollege_ID.Text = cid.ToString();
                lblcollegename.Text = my.Get_College(cid);
            }



            if (!IsPostBack)
            {
                SqlDataSource1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("Please Select", "-1"));
            }

            lblReturnDt.Text = DateTime.Now.ToShortDateString();

            
 
        }

     

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            A_Handler = new Book_Issue_ReturnHandler();
            A1 = new Book_Issue_Return();

            A1.Bir_id = Convert.ToInt32(DropDownList1.SelectedValue.ToString());            
            A1.Reg_id = Convert.ToInt32(lblReg_ID.Text);
            A1.Mem_id = Convert.ToInt32(DropDownList2.SelectedValue.ToString());
            A1.Acc_id = Convert.ToInt32(lblAccID.Text);
            A1.Issue_dt = Convert.ToDateTime(lblIssue_Dt.Text);
            A1.Issue_days =Int32.Parse( lblIssueDay.Text);
            A1.Due_dt = Convert.ToDateTime(lblDueDt.Text);

             

            A1.Return_dt = DateTime.Now;//DateTime.Parse(TextBox3.Text);
            TimeSpan t = A1.Return_dt -  A1.Due_dt;

            int day = (int)t.TotalDays;
            lblTotDay.Text = "Total Days : " + day.ToString();

            A1.Due_day = 0;//Int32.Parse(lblTotDay.Text);
            A1.Is_return = true;

            if (t.TotalDays <= 0)
            { 
                A1.Is_fine = false;
                A1.Fine_rate = 0;
                A1.Fine_amt = 0;
             }
            else
            {
                A1.Is_fine = true;
                A1.Fine_rate = Decimal.Parse(lblFinePer_Day.Text);
                A1.Fine_amt = A1.Fine_rate * (decimal)t.TotalDays;
             }
             
            bool B = A_Handler.UpdateBook_Issue_Return(A1);
            if (B == true)
            {

                lblMsg.Text = "Book is Returned";
                GridView1.DataBind();
            }
            else
            {
                lblMsg.Text = "Book is Not Returned";
            }
        }


        public void Show_Setting(String ROLE, int COLLEGE_ID)
        {
            string sql = "select * from VSetting where Mem_Role='" + ROLE + "' and college_id =" + COLLEGE_ID + " ";
            DataTable dt = new DataTable();
            MyClass cs = new MyClass();
            dt = cs.GetTable(sql);
            if (dt.Rows.Count > 0)
            {
                lblFinePer_Day.Text = dt.Rows[0]["Fine_Per_Day"].ToString();
                 
            }

        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Bir_id = Int32.Parse(DropDownList1.SelectedValue.ToString());
            show_Book(Bir_id);
        }



        public void show_Book(int BIR_ID)
        {

            string sql = "select * from VBook_Issue_Return where bir_id = " + BIR_ID;
            DataTable dt = new DataTable();
            MyClass cs = new MyClass();
            dt = cs.GetTable(sql);

            if (dt.Rows.Count > 0)
            {
                lblAccID.Text = dt.Rows[0]["Acc_id"].ToString();


                TextBox1.Text = dt.Rows[0]["Title"].ToString();
                TextBox2.Text = dt.Rows[0]["Author"].ToString();
                TextBox3.Text = dt.Rows[0]["Subject"].ToString();
                TextBox4.Text = dt.Rows[0]["Book_Type"].ToString();
                Image2.ImageUrl = "~/Book_Img/" + dt.Rows[0]["photo"].ToString();

                lblIssue_Dt.Text = dt.Rows[0]["Issue_dt"].ToString();
                lblIssueDay.Text = dt.Rows[0]["Issue_days"].ToString();
                 
                lblDueDt.Text = dt.Rows[0]["Due_dt"].ToString();

                int mem_id = Int32.Parse(dt.Rows[0]["mem_id"].ToString());

                DropDownList2.SelectedValue = mem_id.ToString();
                show_Member(mem_id);

                DateTime dtRtn = DateTime.Now;
                DateTime dtDue = DateTime.Parse(dt.Rows[0]["Due_dt"].ToString());
                TimeSpan TS = dtRtn.Subtract(dtDue);
                int D = TS.Days;
                double F=0;
                if(lblFinePer_Day.Text != "")
                { F = double.Parse(lblFinePer_Day.Text );}
                else
                { F=0; }

                if (D > 0 && F > 0)
                { TextBox8.Text = (D * F).ToString(); }
                else
                { TextBox8.Text = ""; }


                
            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }


        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int aid = Int32.Parse(DropDownList1.SelectedValue.ToString());
            int id = Int32.Parse(DropDownList2.SelectedValue.ToString());
            show_Member(id);
            //  show_Accession(aid);

        }
      

        public void show_Member(int id)
        {

            string sql = "select *from VMember  where mem_id = " + id;
            DataTable dt = new DataTable();
            MyClass cs = new MyClass();
            dt = cs.GetTable(sql);

            if (dt.Rows.Count > 0)
            {
                TextBox5.Text = dt.Rows[0]["Member_Name"].ToString();
                TextBox6.Text = dt.Rows[0]["Dep_name"].ToString();
                TextBox7.Text = dt.Rows[0]["College_Name"].ToString();
                //TextBox8.Text = dt.Rows[0]["Fine_amt"].ToString();

                 
                lblRole.Text = dt.Rows[0]["role"].ToString();
                
                

                Image1.ImageUrl = "~/img/" + dt.Rows[0]["photo"].ToString();
            }
            else
            {
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
            }

            //====== Show Setting ==========

            string role = lblRole.Text;
            int Col_id = Int32.Parse(lblCollege_ID.Text);

            Show_Setting(role, Col_id);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LIBRARIAN/Default.aspx");
        }

        protected void btnReport(object sender, EventArgs e)
        {
            Response.Redirect("~/Report/Rpt_Book_Return.aspx");
        }

        


    }
}