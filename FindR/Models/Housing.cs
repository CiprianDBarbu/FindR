﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindR.Models
{
    public class Housing
    {
        [Key, Column("HousingId")]
        public int Housing_Id { get; set; }

        //public List<string> Images { get; set; }    //Images will be stored online, each of it has a link that will be stored

        public int Price { get; set; }

        public int NoOfRooms { get; set; }


        //public int FullAddressId { get; set; }

        //one - to - one
        public CompleteAddress FullAddress { get; set; }


        public bool IsTaken { get; set; }   //Check if that housing is already listed(or free for usage)
    }
}
