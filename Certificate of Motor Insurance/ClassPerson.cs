using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificate_of_Motor_Insurance
{
    class Person
    {
        public DateTime DateOfBirth { get; private set; }
        public int Age { get { return (int)((DateTime.Now - DateOfBirth).TotalDays / 365.242199); } }
        public string? Gender { get; private set; }
        public string? FullName { get; private set; }
        public string? Location { get; private set; }
        public Car Car { get; private set; }
        public Person(string? gender, string? fullName, DateTime dateOfBirth, string? location, Car car )
        {
            Gender = gender;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Location = location;
            Car = car;
        }
    }
}
