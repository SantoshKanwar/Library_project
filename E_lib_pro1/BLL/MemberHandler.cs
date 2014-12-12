using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;using System.Web.UI;using System.Web.UI.WebControls;
using System.Data.SqlClient;


using AURO.DAL;        
 
namespace AURO.BLL
{
  public class MemberHandler
  {
 
        // Handle to the Member DBAccess class
        MemberDBAccess memberDb = null;
 
        public MemberHandler()
        {
            memberDb = new MemberDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of members, we can put some logic here if needed
        public List<Member> GetMemberList()
        {
            return memberDb.GetMemberList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of members, we can put some logic here if needed
        public List<Member> GetMemberList(string sql)
        {
            return memberDb.GetMemberList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of members, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select *from VMember";
            return memberDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of members, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return memberDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of members, we can put some logic here if needed
        public bool UpdateMember(Member b1)
        {
            return memberDb.UpdateMember(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of members, we can put some logic here if needed
        public Member GetMemberDetails(int ID)
        {
            return memberDb.GetMemberDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of members, we can put some logic here if needed
        public bool DeleteMember(Member b1)
        {
            return memberDb.DeleteMember(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of members, we can put some logic here if needed
        public bool AddNewMember(Member b1)
        {
            return memberDb.AddNewMember(b1);
        }
    }
}

