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
        public double Height { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double BMI { get; set; }

        public Person(string name, double weight, int height, int age, string gender, double bmi)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            Gender = gender;
            BMI = bmi;                            
        }

        public int CalculateStatus(int age, double bmi)
        {
            int weightStatus = 0;
            if (age < 19)
            {
                weightStatus = 3;
            }
            else
            {
                if (age >= 19 && age <= 24)
                {
                    if (bmi < 19)
                        weightStatus = 0;
                    else if (bmi >= 19 && bmi <= 24)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
                else if (age >= 25 && age <= 34)
                {
                    if (bmi < 20)
                        weightStatus = 0;
                    else if (bmi >= 20 && bmi <= 25)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
                else if (age >= 35 && age <= 44)
                {
                    if (bmi < 21)
                        weightStatus = 0;
                    else if (bmi >= 21 && bmi <= 26)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
                else if (age >= 45 && age <= 54)
                {
                    if (bmi < 22)
                        weightStatus = 0;
                    else if (bmi >= 22 && bmi <= 27)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
                else if (age >= 55 && age <= 64)
                {
                    if (bmi < 23)
                        weightStatus = 0;
                    else if (bmi >= 23 && bmi <= 28)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
                else if (age >= 64)
                {
                    if (bmi < 24)
                        weightStatus = 0;
                    else if (bmi >= 24 && bmi <= 29)
                        weightStatus = 1;
                    else
                        weightStatus = 2;
                }
            }
            return weightStatus;
        }
    }
}
