using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokolCv.Models
{
    public class Measure
    {
        [DisplayName("Parametr")]
        public string Parameter { get; set; }
        [DisplayName("Naměřená hodnota")]
        public double MeasuredValue { get; set; }
        [DisplayName("Jednotka")]
        public string Unit { get; set; }
        [DisplayName("Vyhovuje")]
        public bool IsOptimal { get; set; }
    }
}
