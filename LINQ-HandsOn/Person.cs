using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HandsOn
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(string name,string lastname,int age)
        {
            FirstName = name;
            LastName = lastname;
            Age = age;

        }
    }
}
