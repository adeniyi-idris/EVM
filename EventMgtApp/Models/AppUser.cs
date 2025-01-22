using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventMgtApp.Models
{
    public class AppUser:IdentityUser
    {
        public string? NickName { get; set; }
        [NotMapped]
        public string? RoleId { get; set; }
        
        public string? Role { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? RoleList { get; set; }
        public List<Registration>? Registrations { get; set; }
        public List<Event> Events { get; set; }
    }
}
