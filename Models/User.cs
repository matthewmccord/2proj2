using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2proj2.Models
{
    public class User
    {
        [Key]
        [Required]
        public int GroupId { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a number between 1 and 15")]
        [Range(0, 15)]
        public int GroupSize { get; set; }
        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        // add in the connection with the time slot
        [Required]
        public int TimeId { get; set; }
        public Time Time { get; set; }


    }
}
