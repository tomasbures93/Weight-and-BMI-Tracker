using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.models
{
    public enum GenderType
    {
        Male,
        Female,
        Diverse
    }
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderType? Gender { get; set; }                         // 0 - Male , 1 - Female, 2 - Other
        public double? BMIcalc {
            get
            {
                if (Height > 0) // To prevent division by zero
                {
                    return Weight / (Height/100 * Height/100); // BMI formula: weight (kg) / height (m)^2
                }
                return 0;
            }
        }                        // That has to be calculated
        public List<Weight>? Weights { get; set; }

        public User() { }

        public User(string name)
        {
            UserName = name;
        }
    }
}
