using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasis.Models
{
    internal class Teacher : Person
    {
        public Teacher(string teachingSubject, string name, string surname, string address, string phone, int age) 
            : base(name, surname, address, phone, age)   
        {
            TeachingSubject = teachingSubject;
        }

        public string TeachingSubject { get; set; }
    }
}
