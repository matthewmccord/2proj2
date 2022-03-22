using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace _2proj2.Models
{
    public class User
    {
        public User()
        {
            MakeAvailable();
        }

        [Key]
        public int GroupId { get; set; } //aka AppointmentId

        // add in the connection with the time slot
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsAvailable { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        [Range(0, 15)]
        public int? GroupSize { get; set; }

        public List<string> ErrorList()
        {
            List<string> errors = new List<string>();
            if (IsAvailable == false)
            {
                if (string.IsNullOrEmpty(Name)) errors.Add("Name is required.");
                if (string.IsNullOrEmpty(Email)) errors.Add("Email is required.");
                if (GroupSize == null) errors.Add("Group Size is required.");
            }
            return errors;
        }

        public void MakeAvailable()
        {
            Name = "";
            Email = "";
            Phone = "";
            IsAvailable = true;
            GroupSize = null;
        }


    }


}
