using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasedSalary
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;
        private static int count;
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
        public static int Count
        {
            get { return count; }
        }
        public Person(string firstName, string lastName, int age, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.salary = salary;
            Person.count += 1;
        }
        public void IncreasedSalary(double percent)
        {
            if (this.Age > 30)
            {
                this.salary += this.salary * percent / 100;
            }
            else
            {
                this.salary += this.salary * percent / 200;


            }
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
        }
    }
    }
