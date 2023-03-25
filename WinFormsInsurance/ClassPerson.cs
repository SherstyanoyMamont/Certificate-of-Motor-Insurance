using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificate_of_Motor_Insurance
{
    public class Person
    {
        public DateTime DateOfBirth { get; private set; }
        public int Age { get { return (int)((DateTime.Now - DateOfBirth).TotalDays / 365.242199); } }
        public string? Gender { get; private set; }
        public string? FullName { get; private set; }
        public string? Location { get; private set; }
        public string? Email { get; private set; }
        public string? PhoneNumber { get; private set; }
        public int ID { get; private set; }
        public Car Car { get; private set; }
        internal Insurance Insurance { get; private set; }
        public Person(string? gender, string? fullName, DateTime dateOfBirth, string? location, Car car, string? email, string? phoneNumber)
        {
            Gender = gender;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Location = location;
            Car = car;
            Email = email;
            PhoneNumber = phoneNumber;
            Random rnd = new Random();
            ID  = rnd.Next(1000,9999);
        }
    }
}
