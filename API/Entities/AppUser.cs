using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsActive { get; set; }
        public string Picture { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime Registered { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; } = DateTime.UtcNow;
        public string Company { get; set; }
        public string City { get; set; }
        public string About { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentDescription { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public ICollection<UserLawn> Lawns { get; set; } // Navigation property
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}