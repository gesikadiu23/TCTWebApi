using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasis.Models
{
    internal abstract class Person
    {
        public Person(string a, string v, string ad, string fae, int fa)
        {
            Name = a;
            Surname = v;
            Address = fae;
            Phone = ad;
            Age = fa;
        }

   
        public Person()
        {

        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
}
