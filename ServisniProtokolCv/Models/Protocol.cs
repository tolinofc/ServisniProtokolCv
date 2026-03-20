using ServisniProtokolCv.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokolCv.Models
{
    public class Protocol : IHtmlExportable, IDrawable
    {
        public string ProtocolNumber { get; set; }
        public DateTime MeasureDate = DateTime.Now;
        public Customer Customer = new Customer();
        public Device Device = new Device();
        public BindingList<Measure> MeasureList = new BindingList<Measure>();

        public bool IsOptimal()
        {
            foreach (Measure measure in MeasureList)
            {
                if (!measure.IsOptimal)
                {
                    return false;
                }
            }

            return true;
        }
        public void Draw()
        {
            throw new NotImplementedException();
        }

        public string ExportHTML()
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine("<div id='protokol'>");
            html.AppendLine("<h1>Potvrzení o provedení měření</h1>");
            html.AppendLine("<div id='datum'>Datum měření: 25.2.2012</div>");
            html.AppendLine("<div id='cisloProtokolu'>Číslo protokolu: AB123525</div>");

            return html.ToString();
        }

        public string ExportCSS()
        {
            StringBuilder css = new StringBuilder();

            css.AppendLine("div#protokol { margin:2em; border:1px solid black; }");
            css.AppendLine("div#datum { float:left; margin:1em; width:40%;  }");
            css.AppendLine("div#cisloProtokolu { text-align:right; float:right; margin:1em; width:40%; }");
            css.AppendLine("div#protokol { margin:2em; border:1px solid black; }");

            return css.ToString();
        }
    }
}
