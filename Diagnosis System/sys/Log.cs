using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Diagnosis_System.sys
{
    class Log
    {
        public Log()
        {

        }
        public Log(string eventthing,string user)
        {
            this.Time = DateTime.Now;
            this.Event = eventthing;
            this.User = user;
            WriteInLog();
        }
        public DateTime Time { get; set; }
        public string Event { get; set; }
        public string User { get; set; }

        public void WriteInLog()
        {
            AccessLib.AccessLib ac = new AccessLib.AccessLib("./Diagnosis.mdb");
            
            string table = "sys_log";
            List<string> items = new List<string> { "recordtime", "event", "[user]" };
            List<string> values = new List<string> { this.Time.ToString(), this.Event, this.User };
            ac.Insert(table, items, values);
            ac.CloseConn();
        }

        public DataSet ShowLog()
        {
            DataSet ds = new DataSet();            
            AccessLib.AccessLib ac = new AccessLib.AccessLib(Program.MdbFile);
            ds = ac.Select("sys_log", " 1=1 order by id desc");           
            ac.CloseConn();
            return ds;
        }

        public DataSet ShowLog(DateTime dt)
        {
            DataSet ds = new DataSet();
            AccessLib.AccessLib ac = new AccessLib.AccessLib(Program.MdbFile);
            //select* from TblName where DateDiff("d", FDate, #2012-12-12#) <=0 AND DateDiff( "d", FDate, #2012-12-12#)>=0
            ds = ac.Select("sys_log", " DateDiff('d', recordtime, #"+dt.ToString("yyyy-MM-dd")+ "#) <=0 AND DateDiff( 'd', recordtime, #" + dt.ToString("yyyy-MM-dd") + "#)>=0  order by id desc");
            ac.CloseConn();
            return ds;
        }
    }
}
