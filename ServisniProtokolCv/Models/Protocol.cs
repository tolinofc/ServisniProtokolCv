using System;
using System.Collections.Generic;
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
        public List<Measure> MeasureList { get; set; }
    }
}
