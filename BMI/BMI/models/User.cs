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
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string DateOfBirth { get; set; }         // Rework to DateTime
        public string Gender { get; set; }
        public double? BMI { get; set; }

        public List<Weight>? Weights { get; set; }
    }
}
