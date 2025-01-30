using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.Models
{
    class Person
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public Person(string name, double weight, int height, int age)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
