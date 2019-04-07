using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagnosis_System.consultation
{
    class Consultation
    {    
        public Consultation()
        {

        }

        public void CreateConsultation(string patientId,string date,string illness,string management,string cost)
        {
            AccessLib.AccessLib ac = new AccessLib.AccessLib(Program.MdbFile);
            List<string> itemList = new List<string> { "patientId","consultationdate","illness","management","cost"};
            List<string> valueList = new List<string> { patientId,date,illness,management,cost};
            ac.Insert("consultation", itemList, valueList);
            ac.CloseConn();
        }

        public void GetOneConsultation()
        {
            AccessLib.AccessLib ac = new AccessLib.AccessLib(Program.MdbFile);
        }
    }
}
