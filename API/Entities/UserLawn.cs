using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class UserLawn
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public int UserId { get; set; } // Foreign key
        public AppUser User { get; set; } // Navigation property
        public bool isMain { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double LawnSizeInSquareMetres { get; set; }
        public DateTime LastMowed { get; set; }
    }
}