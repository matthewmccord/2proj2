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
        [Required]
        public string Name { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        // add in the connection with the time slot
        [Required]
        public int TimeId { get; set; }


    }
}
