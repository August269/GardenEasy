using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUserRole
    {
        [Key]
        public int Id { get; set; }
        public AppUser User { get; set; }
        public AppRole Role { get; set; }
    }
}