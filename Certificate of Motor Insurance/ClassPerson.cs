using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificate_of_Motor_Insurance
{
    class Person
    {
        public string Gender { get; private set; }
        public string FullName { get; private set; }
        public int Age { get; private set; }
        public string Location { get; private set; }

        public Person(string gender, string fullName, int age, string location)
        {
            Gender = gender;
            FullName = fullName;
            Age = age;
            Location = location;
        }
    }
}
