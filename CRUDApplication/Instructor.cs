using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Application
{
    public class Instructor : Person
    {
        public string Specialization { get; set; }
        public  decimal Salary { get; set; }
        public string Department { get; set; }

        public Instructor(string name,int age ,string address,string email,string specialization, decimal salary, string department)
        {
            Name = name;
            Age = age;
            Address = address;
            Email = email;
            Specialization = specialization;
            Salary = salary;
            Department = department;
        }

        public Instructor()
        {
            
        }
    }
}
