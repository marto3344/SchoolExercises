using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }

        }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} - {this.age}";
        }
        public bool CheckAge()
        {
            if (this.Age > 30)
            {
                return true;
            }
            else return false;
        }
    }
}