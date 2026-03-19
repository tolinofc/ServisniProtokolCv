using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokolCv.Models
{
    public class Measure
    {
        public string Parameter { get; set; }
        public double MeasuredValue { get; set; }
        public string Unit { get; set; }
        public bool Optimal { get; set; }
    }
}
