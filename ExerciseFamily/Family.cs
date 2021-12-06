using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFamily
{
    public class Family
    {
        private List<Person> parents=new List<Person>();
        private List<Person> kids=new List<Person>();

        public void AddParent(Person parent)
        {
            this.parents.Add(parent);
        }
        public void AddKid(Person kid)
        {
            this.kids.Add(kid);
        }
        public override string ToString()
        {
            string result="";
            foreach (var parent in parents)
            {
                result = result + $"{parent.Name} {parent.Age}" + $"\n";
            }
            foreach (var kid in kids.OrderByDescending(x=>x.Age))
            {
                result = result + $"{kid.Name} {kid.Age}" + $"\n";
            }
            return result;
        }
    }
}
