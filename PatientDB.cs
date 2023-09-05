using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Proj1_SampleConApp;
using System.Xml.Serialization;

namespace Assesments
{
    class PatientDB : IPatient
    {
        static string filename = @"C:\Users\skousars\source\repos\Assesments\Assesments\TestText\menu.txt";
        public static List<PatientDetails1> storage = new List<PatientDetails1>();
        static int count = storage.Count();
        //string filename = @"C:\Users\skousars\source\repos\Assesments\Assesments\PatientAssignent\Data.xml";
        public void add(PatientDetails1 pd)
        {
            storage.Add(pd);
            Console.WriteLine("Patient Added Successfully");
        }

        public void delete(PatientDetails1 pd, int id)
        {
            if (pd.PatientId == id)
            {
                storage.Remove(pd);
            }
            else
            {
                Console.WriteLine("Not Deleted the record value is not present");
            }
        }

        public void display()
        {

        }

        public void upadate(PatientDetails1 pd, int id)
        {
            if (pd.PatientId == id)
            {
                Console.WriteLine("Yes to update");
            }
        }


        static void Main(string[] args)
        {


            XmlSerialization();
            // FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var content = File.ReadAllText(filename);
            Console.WriteLine(content);
            int choice = Utilities.GetInteger("Enter the choice");
            do
            {
                switch (choice)
                {
                    case 1:
                        adding();
                        break;
                    case 2:
                        Console.WriteLine("Entert the id to delete");
                        int id = int.Parse(Console.ReadLine());
                       
                       // delete();

                        break;
                    case 3:
                        //Update();
                        break;
                    default: break;

                }
            } while (true);
        }

        private static void adding()
        {
            int id = Utilities.GetInteger("Enter the Patient Id");
            string name = Utilities.GetString("Enter the patient name");
            string date = Utilities.GetString("Enter the date of appointment");
            string docname = Utilities.GetString("Enter the doctor name");
            double bill = Utilities.GetDouble("Enter the bill amount");
            PatientDetails1 info = new PatientDetails1(id, name, date, docname, bill);
            new PatientDB().add(info);
            //return info;
        }

        private static void XmlSerialization()
        {
            PatientDetails1 ps = new PatientDetails1();
            FileStream fs = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer fm = new XmlSerializer(typeof(PatientDetails1));
            fm.Serialize(fs, ps);
        }
        
    }
}
