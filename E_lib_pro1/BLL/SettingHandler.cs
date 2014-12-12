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
  public class SettingHandler
  {
 
        // Handle to the Setting DBAccess class
        SettingDBAccess settingDb = null;
 
        public SettingHandler()
        {
            settingDb = new SettingDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of settings, we can put some logic here if needed
        public List<Setting> GetSettingList()
        {
            return settingDb.GetSettingList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of settings, we can put some logic here if needed
        public List<Setting> GetSettingList(string sql)
        {
            return settingDb.GetSettingList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of settings, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select *from VSetting";
            return settingDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of settings, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return settingDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of settings, we can put some logic here if needed
        public bool UpdateSetting(Setting b1)
        {
            return settingDb.UpdateSetting(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of settings, we can put some logic here if needed
        public Setting GetSettingDetails(int ID)
        {
            return settingDb.GetSettingDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of settings, we can put some logic here if needed
        public bool DeleteSetting(Setting b1)
        {
            return settingDb.DeleteSetting(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of settings, we can put some logic here if needed
        public bool AddNewSetting(Setting b1)
        {
            return settingDb.AddNewSetting(b1);
        }
    }
}

