using System;
using System.Collections.Generic;
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

        public Patient(string name,int age,int sex,string telphone,string address)
        {
            this.Name = name;
            this.Age = age;
            this.PatientSex = (sex)sex;
            this.TelphoneNo = telphone;
            this.Address = address;
        }

        public void CreatePatient()
        {
            AccessLib.AccessLib ac = new AccessLib.AccessLib(Program.MdbFile);
            List<string> itemList = new List<string> { "[name]", "sex", "birthyear", "telphone", "address" };
            List<string> valueList = new List<string> { this.Name,((int)this.PatientSex).ToString(),this.Age.ToString(),this.TelphoneNo,this.Address};
            ac.Insert("patient", itemList, valueList);
            ac.CloseConn();
            sys.Log log = new sys.Log("创建了 "+this.Name+" 患者档案",Program.User);
        }
    }
}
