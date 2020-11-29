using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WPFW12_2_Final.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Range(1, 600, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Huisnummer { get; set; }
        [DataType(DataType.Text)]
        public string Straatnaam { get; set; }
        [StringLength(6, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Postcode { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        public List<Student> Vrienden { get; set; }
    }
}

