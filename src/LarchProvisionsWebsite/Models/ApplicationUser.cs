using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LarchProvisionsWebsite.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    [Table("ApplicationUsers")]
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int LarchCustomerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public ApplicationUser()
        {
            Menus = new HashSet<Menu>();
            Orders = new HashSet<Order>();
        }
    }
}