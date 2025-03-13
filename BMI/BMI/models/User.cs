using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }                         // 0 - Male , 1 - Female, 2 - Other
        public double? BMI { get; set; }                        // That has to be calculated
        public List<Weight>? Weights { get; set; }

      
    }
}
