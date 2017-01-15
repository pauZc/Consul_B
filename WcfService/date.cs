using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class date
    {
        public int id { get; set; }
        public int id_patient { get; set; }
        public DateTime datep{ get; set; }
        public double fat { get; set; }
        public double skinny { get; set; }
        public double weight { get; set; }
        public string comment { get; set; }
        public string medication { get; set; }
    }
}