using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    [Serializable]
   public class PatientDetails1
    {
        public PatientDetails1()
        {
        }

        public PatientDetails1(int id, string name, string date, string docname, double bill)
        {
            this.PatientId = id;
            this.PatientName = name;
            Date = date;
            this.Doctor = docname;
            this.bill = bill;
        }

        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Date { get; set; }
        public string Doctor { get; set; }
        public double bill { get; set; }

        public override int GetHashCode()
        {
            return PatientId;
        }
    }
}
