using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);

    internal class Class1
    {


        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";
        public static long Age = 0;
        public static long ContactNumber = 0;
        public static long StudentNo = 0;

        public static string getFirstName(string FirstName) 
        {
            return FirstName;
        }
        public static string getLastName(string LastName) 
        {
            return LastName;
        }
        public static string getMiddleName(string MiddleName)
        {
            return MiddleName;
        }
        public static string getAddress(string Address)
        {
            return Address;
        }
        public static string getProgram(string Program) 
        {
            return Program;
        }
        public static long getAge(long Age) 
        {
            return Age;
        }
        public static long getContactNo(long Contact) 
        {
            return ContactNumber;
        }
        public static long getStudentNo(long StudentNo)
        {
            return StudentNo;
        }

    }

}
