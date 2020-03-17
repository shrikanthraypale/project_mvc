using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspEmpWebFrm
{
    public class EmpInfo
    {

        public int Empid { get; set; }
        public string Empname { get; set; }
        public string Jobname { get; set; }
        public int Sal { get; set; }
        public string Dept { get; set; }
        public EmpInfo() { }  //Default Constructor Not requried but u can
    }
}