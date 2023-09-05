using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    interface IPatient
    {
        void add(PatientDetails1 pd);
        void delete(PatientDetails1 pd, int id);
        void upadate(PatientDetails1 pd, int id);
        void display();
            
    }
}
