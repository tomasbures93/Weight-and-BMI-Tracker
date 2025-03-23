using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.Models
{
    public class ProfilViewModel
    {
        public List<int> HeightNumberList { get; set; }
        public List<int> WeightNumberList { get; set; }
        public int HeightSelectedIndex { get; set; }
        public int WeightSelectedIndex { get; set; }

        public ProfilViewModel()
        {
            HeightNumberList = Enumerable.Range(50, 171).ToList();
            HeightSelectedIndex = 125;
            WeightNumberList = Enumerable.Range(40, 160).ToList();
            WeightSelectedIndex = 30;
        }
    }
}
