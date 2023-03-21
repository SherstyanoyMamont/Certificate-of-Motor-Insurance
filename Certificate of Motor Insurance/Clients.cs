using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Certificate_of_Motor_Insurance
{
    internal class List<Clients>
    {
        //create list of users
        public List<Clients> list = new List<Clients>();

        //add a new user with the information above
        Clients.Add(new User(
        time: now,
        gender: gender,
            name: name,
            age: age));

        //... do other things.... for instance, add more users

        //search user with a certain name in the list
        var userWithNameWilly = users.Single(user => user.Name == "Willy");

        // recover the information which has been saved
        var retrievedAge = userWithNameWilly.Age;
        var retrievedInsertionDate = userWithNameWilly.Time;
        var retrievedGender = userWithNameWilly.Gender;

        //do anything with the information
    }
}
