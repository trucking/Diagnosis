using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Diagnosis_System.patient
{
    class Patient
    {
        public enum sex
        {
            Man,
            Woman
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public sex PatientSex { get; set; }
        public string TelphoneNo { get; set; }
        public string Address { get; set; }

        public Patient()
        {

        }
        public Patient(string name)
        {
            this.Name = name;
        }
        public Patient(string name,int age,sex sex,string telphone,string address)
        {
            this.Name = name;
            this.Age = age;
            this.PatientSex = sex;
            this.TelphoneNo = telphone;
            this.Address = address;
        }
        private int GetPatientId()
        {
            AccessLib.AccessLib ac = new AccessLib.AccessLib(Program.MdbFile);
            DataSet  ds = ac.Select("patient", " [name] = '" + this.Name + "'");
            return Convert.ToInt16(ds.Tables[0].Rows[0][0]);
        }

        public void CreatePatient()
        {
            AccessLib.AccessLib ac = new AccessLib.AccessLib(Program.MdbFile);
            List<string> itemList = new List<string> { "[name]", "sex", "birthyear", "telphone", "address" };
            string birthYear = this.ChangeBirthYear(this.Age);
            List<string> valueList = new List<string> { this.Name,((int)this.PatientSex).ToString(),birthYear,this.TelphoneNo,this.Address};
            ac.Insert("patient", itemList, valueList);
            ac.CloseConn();
            sys.Log log = new sys.Log("创建了 "+this.Name+" 患者档案",Program.User);
        }

        public string ChangeBirthYear(int age)
        {
            string result = "";
            DateTime date = DateTime.Now;
            result = date.AddYears(-age).ToString("yyyy-MM-dd");
            return result;
        }

        public int ChangeAge(string birthyear)
        {
            int age = 0;
            DateTime date = DateTime.Now;
            age = date.Year - Convert.ToInt16(birthyear.Substring(0, 4));
            return age;
        }

        public string SexToString(int sex)
        {
            if(sex == 0)
            {
                return "男";
            }
            else
            {
                return "女";
            }
        }

        public DataSet GetConsultation()
        {
            int uid = this.GetPatientId();
            AccessLib.AccessLib ac = new AccessLib.AccessLib(Program.MdbFile);
            DataSet ds = new DataSet();
            List<string> items = new List<string> { "consultationdate", "illness", "management", "cost" };
            ds = ac.Select(items,"consultation"," patientid = " + uid);
            return ds;
        }
    }
}
