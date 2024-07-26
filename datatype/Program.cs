using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace datatype
{
    internal class employee
    {
        static void Main(string[] args)
        { }
            //feild
            private string name;
        private int emplyeeId;
        private double salary;
        //properties to acess and modify private field
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int EmployeeId
        {
            get { return EmployeeId; }

        }
        private double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    Console.WriteLine("salary cannot be negative");
            }
        }
    }
}



        
