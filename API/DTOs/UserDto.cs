using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public string Picture { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string About { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public ICollection<UserLawn> Lawns { get; set; }
    }
}