using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebAppDatasetDemo
{
    public class DataLayer
    {
        private string constr = "";
        public DataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["ShrikantdbConstring"].ConnectionString;
        }
        public string InsertaInfo(webInfo inf)
        {
            string insertquery = string.Format("Insert into webInfo(Id,name,marks)values({0},'{1}',{2})",inf.Id,inf.name,inf.marks);
            DataSet ds = new DataSet();
            int i = 0;
            string msg = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(insertquery, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    i=da.Fill(ds);
                    da.Update(ds);
                }
            }
            catch (Exception ex)
            {

            }
            //return i;
            if (i > 0)
            {
              msg= string.Format("one row is inserted");
            }
            return msg;
        }
        public DataSet Showdata()
        {
            string selectquery = "select * from webInfo";
            DataSet ds = new DataSet();
            try {
                using (SqlConnection con = new SqlConnection(constr)) 
                {
                    SqlCommand cmd = new SqlCommand(selectquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
            }
            return ds;
        }
       
    }
}