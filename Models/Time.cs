using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace _2proj2.Models
{
    public class Time
    {
        [Key]
        public int TimeID { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool Available { get; set; }
    }
}
