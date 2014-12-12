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
 
namespace AURO.DAL
{
  public class AccessionDBAccess
  {
     public bool AddNewAccession(Accession b1)
     {   
             
      b1.Acc_id = GetNewTBLID();       
      string sql = "insert into [Accession] ([Acc_id],[Reg_id],[Book_id],[Acc_code],[Location],[College_id],[Is_issue],[Status]) values(" + b1.Acc_id+ ", " + b1.Reg_id+ ", " + b1.Book_id+ ", '" + b1.Acc_code+ "', '" + b1.Location+ "', " + b1.College_id+ ", " + b1.Is_issue+ ", " + b1.Status+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateAccession(Accession b1)
     {   
             
      string sql = "update [Accession] set [Reg_id]=" + b1.Reg_id+ " ,[Book_id]=" + b1.Book_id+ " ,[Acc_code]='" + b1.Acc_code+ "',[Location]='" + b1.Location+ "',[College_id]=" + b1.College_id+ " ,[Is_issue]=" + b1.Is_issue+ ",[Status]=" + b1.Status+ "   where [Acc_id] =" + b1.Acc_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteAccession(Accession x1)
     {   
             
      string Sql = "delete from [Accession]  where [Acc_id] =" + x1.Acc_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Accession GetAccessionDetails(int x1)
        { 
          
            string Sql = "select * from [Accession]   where [Acc_id] =" + x1 +" ";
            
            
            Accession b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Accession 
                    b1 = new Accession();
    
                    //Now lets populate the employee details into the list of Accession 
                    b1.Acc_id = Convert.ToInt32(row["Acc_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Acc_code = row["Acc_code"].ToString();
                    b1.Location = row["Location"].ToString();
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Is_issue =Convert.ToInt32( row["Is_issue"]);
                    b1.Status = Convert.ToInt32(row["Status"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Accession> GetAccessionList()
        { 
            string Sql = "select * from [Accession]"; 
            List<Accession> listAccession = null;
  
            //Lets get the list of all Accession in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Accession 
                    listAccession = new List<Accession>();
   
                    //Now lets populate the Accession details into the list of Accession 
                    foreach (DataRow row in table.Rows)
                    {
                    Accession b1 = new Accession();
                    b1.Acc_id = Convert.ToInt32(row["Acc_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Acc_code = row["Acc_code"].ToString();
                    b1.Location = row["Location"].ToString();
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Is_issue = Convert.ToInt32(row["Is_issue"]);
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listAccession.Add(b1);
                    }
                }
            }
    
            return listAccession;
        }        
        public List<Accession> GetAccessionList(string Sql)
        { 
            List<Accession> listAccession = null;
  
            //Lets get the list of all Accession in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Accession 
                    listAccession = new List<Accession>();
   
                    //Now lets populate the Accession details into the list of Accession 
                    foreach (DataRow row in table.Rows)
                    {
                    Accession b1 = new Accession();
                    b1.Acc_id = Convert.ToInt32(row["Acc_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Acc_code = row["Acc_code"].ToString();
                    b1.Location = row["Location"].ToString();
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Is_issue = Convert.ToInt32(row["Is_issue"]);
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listAccession.Add(b1);
                    }
                }
            }
    
            return listAccession;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VAccession]"; 
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            return table;
        }        
        public DataTable GetList(string Sql)
        { 
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            return table;
        }        
        public int GetNewTBLID()
        { 
            int i = 0;
            string Sql = "select max(Acc_id) from [Accession]";
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            if (table.Rows.Count > 0 && table.Rows[0][0].ToString() !="")
              {
                    i = Convert.ToInt32(table.Rows[0][0].ToString()) + 1;    
               }
               else
               {
                     i = 1;
               }
            return i;
        }        
    }   
 }   

