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

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using E_Libpro.My_Function;

namespace E_lib_pro1.Report
{
    public partial class Rpt_Book_Issue_Return : System.Web.UI.Page
    {
        string Tbl_Name = "[VBook_Issue_Return]";
        string sql = "";
        string reportPath;
        ReportDocument report1;
        DataTable dt = new DataTable();
        int cid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            MyClass my = new MyClass();
            reportPath = Server.MapPath("~/Report/Book_Issue_Return1.rpt");
            report1 = new ReportDocument();
            report1.Load(reportPath);

            if (!IsPostBack)
            {
                string fld = DropDownList1.SelectedValue.ToString();
                string txt = TextBox1.Text;

                if (Session["College_id"] != null)
                {
                    cid = int.Parse(Session["College_id"].ToString());
                    sql = "select * from " + Tbl_Name + " where College_id=" + cid + " and " + fld + " like '" + txt + "%' ";
                    Label1.Text = cid.ToString();
                    Label2.Text = my.Get_College(cid);
                }
                else
                {
                    Label1.Visible = false;
                    Label2.Visible = false;
                    sql = "select * from " + Tbl_Name + " where " + fld + " like '" + txt + "%' ";

                }
                dt = my.GetTable(sql);
                report1.SetDataSource(dt);
                CrystalReportViewer1.ReportSource = report1;
                CrystalReportViewer1.RefreshReport();
            }
        }

        //protected void btnReport_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    MyClass my = new MyClass();
        //    string fld = DropDownList1.SelectedValue.ToString();
        //    string txt = TextBox1.Text;


        //    if (TextBox2.Text == "" && TextBox3.Text == "")
        //    {
        //        sql = "select * from VBook_Issue_Return where  " + fld + " like '" + txt + "%'  ";
        //    }
        //    else
        //    {
        //        DateTime sdate = DateTime.Parse(TextBox2.Text);
        //        DateTime edate = DateTime.Parse(TextBox3.Text);
        //        sql = "select *from VBook_Issue_Return where Issue_dt >='" + sdate + "' and Issue_dt <='" + edate + "' ";
        //    }

        //    dt = my.GetTable(sql);
        //    report1.SetDataSource(dt);
        //    CrystalReportViewer1.ReportSource = report1;
        //    CrystalReportViewer1.RefreshReport();
        //}

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            MyClass my = new MyClass();

            DataTable dt = new DataTable();

            string fld = DropDownList1.SelectedValue.ToString();
            string txt = TextBox1.Text;
            if (Session["College_id"] != null)
            {
                cid = int.Parse(Session["College_id"].ToString());
                sql = "select * from " + Tbl_Name + " where College_id=" + cid + " and " + fld + " like '" + txt + "%' ";
                Label1.Text = cid.ToString();
                Label2.Text = my.Get_College(cid);
            }
            else
            {
                Label1.Visible = false;
                Label2.Visible = false;
                sql = "select * from " + Tbl_Name + " where " + fld + " like '" + txt + "%' ";

            }

            dt = my.GetTable(sql);
            report1.SetDataSource(dt);
            CrystalReportViewer1.ReportSource = report1;
            CrystalReportViewer1.RefreshReport();

            report1.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.Excel, Response, true, "Report"); 
        }

        protected void btnPDF_Click(object sender, EventArgs e)
        {
            MyClass my = new MyClass();

            DataTable dt = new DataTable();

            string fld = DropDownList1.SelectedValue.ToString();
            string txt = TextBox1.Text;
            if (Session["College_id"] != null)
            {
                cid = int.Parse(Session["College_id"].ToString());
                sql = "select * from " + Tbl_Name + " where College_id=" + cid + " and " + fld + " like '" + txt + "%' ";
                Label1.Text = cid.ToString();
                Label2.Text = my.Get_College(cid);
            }
            else
            {
                Label1.Visible = false;
                Label2.Visible = false;
                sql = "select * from " + Tbl_Name + " where " + fld + " like '" + txt + "%' ";

            }

            dt = my.GetTable(sql);
            report1.SetDataSource(dt);
            CrystalReportViewer1.ReportSource = report1;
            CrystalReportViewer1.RefreshReport();

            report1.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "Report"); 

        }

        protected void btnReport_Click1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MyClass my = new MyClass();
            string fld = DropDownList1.SelectedValue.ToString();
            string txt = TextBox1.Text.Trim();


            if (TextBox2.Text == "" && TextBox3.Text == "")
            {
                sql = "select * from VBook_Issue_Return where  " + fld + " like '" + txt + "%'  ";
            }
            else
            {
                DateTime sdate = DateTime.Parse(TextBox2.Text);
                DateTime edate = DateTime.Parse(TextBox3.Text);
                sql = "select *from VBook_Issue_Return where Issue_dt >='" + sdate + "' and Issue_dt <='" + edate + "' ";
            }

            dt = my.GetTable(sql);
            report1.SetDataSource(dt);
            CrystalReportViewer1.ReportSource = report1;
            CrystalReportViewer1.RefreshReport();
        }

       
    }
}