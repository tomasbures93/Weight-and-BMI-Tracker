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
        public GenderType Gender { get; set; }                         // 0 - Male , 1 - Female, 2 - Other
        public double? BMI { get; set; }                        // That has to be calculated
        public List<Weight>? Weights { get; set; }

        public User(string name)
        {
            UserName = name;
            Weight = 0;
            Height = 0;
            DateOfBirth = DateTime.Now;
            Gender = GenderType.Male;
        }
    }
}
