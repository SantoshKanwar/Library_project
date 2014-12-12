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
  public class ReservationHandler
  {
 
        // Handle to the Reservation DBAccess class
        ReservationDBAccess reservationDb = null;
 
        public ReservationHandler()
        {
            reservationDb = new ReservationDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of reservations, we can put some logic here if needed
        public List<Reservation> GetReservationList()
        {
            return reservationDb.GetReservationList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of reservations, we can put some logic here if needed
        public List<Reservation> GetReservationList(string sql)
        {
            return reservationDb.GetReservationList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of reservations, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select *from VReservation";
            return reservationDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of reservations, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return reservationDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of reservations, we can put some logic here if needed
        public bool UpdateReservation(Reservation b1)
        {
            return reservationDb.UpdateReservation(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of reservations, we can put some logic here if needed
        public Reservation GetReservationDetails(int ID)
        {
            return reservationDb.GetReservationDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of reservations, we can put some logic here if needed
        public bool DeleteReservation(Reservation b1)
        {
            return reservationDb.DeleteReservation(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of reservations, we can put some logic here if needed
        public bool AddNewReservation(Reservation b1)
        {
            return reservationDb.AddNewReservation(b1);
        }
    }
}

