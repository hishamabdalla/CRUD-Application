using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Application
{
    
    class Student:Person
    {

        public int StudentId { get; set; }
        public string Faculty { get; set; }
        public string Technology { get; set; }

        public Student(int id, string name, string faculty, int age, string tech, string address, string email)
        {
            StudentId = id;
            Name = name;
            Faculty = faculty;
            Age = age;
            Technology = tech;
            Address = address;
            Email = email;
        }

    }
}
