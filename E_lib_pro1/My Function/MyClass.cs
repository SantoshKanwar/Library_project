using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
namespace E_Libpro.My_Function
{
    public class MyClass
    {
        String cnStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True";
        SqlConnection conn;
        SqlDataAdapter dap;
        SqlCommand cmd;
        public MyClass()
        {
            conn = new SqlConnection(cnStr);

        }
        public int Execute(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public object scalar(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            object i = cmd.ExecuteScalar();
            conn.Close();
            return i;
        }

        public DataTable GetTable(string sql)
        {
            DataTable dt = new DataTable();
            dap = new SqlDataAdapter(sql, conn);
            dap.Fill(dt);
            return dt;
        }

        public int Get_NewId(string TBL, string PK)
        {

            String sql = "select max (" + PK + ") from " + TBL + "";
            object c = scalar(sql);
            int i = 0;
            if (c != null && c.ToString() != "")
            {
                i = int.Parse(c.ToString());
            }
            i = i + 1;
            return i;
        }
        public string Get_College(int cid)
        {
            String sql = "select College_Name from  College where College_id = " + cid;
            object c = scalar(sql);
            string st = "";
            if (c != null && c.ToString() != "")
            {
                st = c.ToString();
            }
           return st;
        }
        
        //public void FillCombo(DropDownList cbo, string TBL, string Fld_Disp, string Fld_Val, string whr)
        //{
        //    cbo.Items.Clear();
        //    string sql = "select " + Fld_Val + ", " + Fld_Disp + " from " + TBL + " " + whr;
        //    DataTable dt = new DataTable();
        //    dt = GetTable(sql);
        //    cbo.DataTextField = Fld_Disp;
        //    cbo.DataValueField = Fld_Val;
        //    cbo.DataSource = dt;
        //    cbo.DataBind();
        //    cbo.Items.Insert(0, new ListItem("Please Select", "-1"));
        //    //cbo.AutoCompleteMode = AutoCompleteMode.Suggest;
        //    //cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
        //}



    }
}
