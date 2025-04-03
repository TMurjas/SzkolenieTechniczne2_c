using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania1Liskov.Logic.Abstract
{
    public abstract class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {

        }
     


        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }


        public abstract decimal GetMinimalSalory();

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
