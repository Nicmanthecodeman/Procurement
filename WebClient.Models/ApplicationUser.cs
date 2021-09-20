using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebClient.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        [Required]
        [StringLength(50)]
        [Column("First_Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Surname")]
        public string Surname { get; set; }



        public virtual ICollection<IdentityUserClaim<int>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<int>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<int>> Tokens { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
