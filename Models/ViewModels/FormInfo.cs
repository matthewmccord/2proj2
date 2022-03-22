using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _2proj2.Models.ViewModels
{
    public class FormInfo
    {
        public FormInfo()
        {
        }

        public FormInfo(DateTime date)
        {
            Date = date;
        }

        [Required]
        public DateTime Date { get; set; }

    }
  
}
