using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace WebClient.Models
{
    public class ApplicationRole : IdentityRole<int>
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
