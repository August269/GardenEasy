using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppRole
    {
        [Key]
        public int Id { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}