using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.models
{
    public class Weight
    {
        public int ID {  get; set; }

        public double WeightValue { get; set; }

        public DateTime Datum { get; set; }

        public Weight() { }

        public Weight(double weight)
        {
            WeightValue = weight;
            Datum = DateTime.Now;
        }
    }
}
