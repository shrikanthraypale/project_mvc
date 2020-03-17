using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AspEmpWebFrm
{
    public class DataLayer
    {
        private string constr = "";
        public DataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["Shridbconstring"].ConnectionString;
        }
        public DataSet DataShow()
        {
            string selectquery = "select * from Emp";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selectquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    //ada.Update(ds);
                }
            }
            catch (Exception ex)
            {
               // throw new Exception(ex.Message);
            }
            return ds;
        }
        /*public string InsertInfo(EmpInfo ein)
        {
            string insertquery = string.Format("Insert into Emp(Empid,Empname,Jobname,Sal,Dept)values({0},'{1}','{2}',{3},'{4}')", ein.Empid,ein.Empname,ein.Jobname,ein.Sal,ein.Dept);
            DataSet ds = new DataSet();
            int i = 0;
            string msg = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(insertquery, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    i = da.Fill(ds);
                    //da.Update(ds);
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
            }
            //return i;
            if (i > 0)
            {
                msg = string.Format("one row is inserted");
            }
            return msg;
        }*/


    }
}