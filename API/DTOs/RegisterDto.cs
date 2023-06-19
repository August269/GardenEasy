using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateOnly? DateOfBirth { get; set; } //optional to make required work!
        [Required]
        public string City { get; set; }
        public string About { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int LawnSizeInSquareMeters { get; set; }
    }
}