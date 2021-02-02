using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppCollins.Models
{
    public class Class
    {
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } // gets/sets name
        [Required]
        [Range(1900, 2021, ErrorMessage = "Number must be between 1900 and 2021.")]
        public int YearOfBirth { get; set; } // gets/sets Year of birth

        public int AgeThisYear()
        {
            int currentYear = DateTime.Now.Year;
            int age = 0;
            age = currentYear - YearOfBirth;
            return age;
        }
    }
}
