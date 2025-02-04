using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.Models
{
    class Person
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        public double Weight { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public double BMI { get; set; }

        public Person(string name, double weight, int height, int age)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            BMI = CalculateBMI();                            
        }

        private int CalculateBMI()
        {
            // TO DO
            return 0;
        }
    }
}
