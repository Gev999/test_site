using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstSite.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required (ErrorMessage="Please enter email")]
        [EmailAddress (ErrorMessage = "Not correct email")]
        public string Email { get; set; }

        [Required (ErrorMessage ="Please enter password")]  
        public string Password { get; set; }

        public int DayOfBirth { get; set; }
        public string MonthOfBirth { get; set; }
        public string YearOfBirth { get; set; }
        public string Sex { get; set; }
    }
}
