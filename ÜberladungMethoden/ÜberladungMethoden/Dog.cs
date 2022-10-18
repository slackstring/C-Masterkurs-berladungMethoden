using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜberladungMethoden
{
    public class Dog
    {
        //Eigenschaften
        string Name { get; set; }
        int Age { get; set; }
        string Owner { get; set; }
        //Konstruktor
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
            Owner = "No owner";
        }
        public Dog(string name, int age, string owner)
        {
            Name = name;
            Age = age;
            Owner = owner;
        }

        public void WriteData()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Owner);
        }
    }
}
