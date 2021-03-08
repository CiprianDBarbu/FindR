using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindR.Models
{
    public enum GenderType
    {
        Male,
        Female,
        Others
    }
    public class ApplicationUser : IdentityUser
    {
        public byte[] ProfilePicture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        
        //one - to - one
        public virtual PersonalAddress Adress { get; set; }
        public string Details { get; set; }

        //Friends list is implemented as Firend table
        public virtual ICollection<Advertisement> Advertisements { get; set; } //An user could have more placed Ads

        public int AttendsTo { get; set; }  //If an user does not have posted Ads, he can attend to only one other housing.
    }
}
