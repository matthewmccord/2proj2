using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2proj2.Models
{
    public class Time
    {
        public int TimeID { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool Available { get; set; }
    }
}
