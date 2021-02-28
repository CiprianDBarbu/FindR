using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindR.Models
{
    public class PersonalAddress
    {
        [Key, Column("PersonalAddressId")]
        public int PersonalAddress_Id { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
