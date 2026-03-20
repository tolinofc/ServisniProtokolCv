using ServisniProtokolCv.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokolCv.Models
{
    public class Measure : IHtmlExportable
    {
        [DisplayName("Parametr")]
        public string Parameter { get; set; }
        [DisplayName("Naměřená hodnota")]
        public double MeasuredValue { get; set; }
        [DisplayName("Jednotka")]
        public string Unit { get; set; }
        [DisplayName("Vyhovuje")]
        public bool IsOptimal { get; set; }

        public string ExportHTML()
        {
            return $"<tr><td>{Parameter}</td><td>{MeasuredValue}{Unit}</td><td>{IsOptimal}</td></tr>";
        }
        public string ExportCSS()
        {
            return "div#mereni { clear:both; padding:1em; }";
        }

    }
}
