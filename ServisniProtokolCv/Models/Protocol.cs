using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokolCv.Models
{
    public class Protocol
    {
        public string ProtocolNumber { get; set; }
        public DateTime MeasureDate = DateTime.Now;
        public Customer Customer = new Customer();
        public Device Device = new Device();
        public BindingList<Measure> MeasureList = new BindingList<Measure>();
    }
}
