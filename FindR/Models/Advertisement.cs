using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindR.Models
{
    public class Advertisement
    {
        [Key, Column("AdvertisementId")]
        public int Advertisement_Id{get;set;}

        //one - to - one
        public virtual ApplicationUser Profile { get; set; }    //person who posted the ad

        //one - to - one
        public virtual Housing Housing { get; set; }

        //public List<ApplicationUser> AttendeesList { get; set; }    //people who are already going to this housing (max number of people is the NoOfRooms of housing)
        public DateTime CheckInDate { get; set; }   //date of Check In
    }
}
