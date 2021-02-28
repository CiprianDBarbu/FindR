using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindR.Models
{
    public class CompleteAddress
    {
        [Key, Column("CompleteAddressId")]
        public int CompleteAddress_Id { get; set; }

        //one - to - many
        public virtual Address Address { get; set; }

        public string Street { get; set; }

        public string Floor { get; set; }

        public int Longitude { get; set; }

        public int Latitude { get; set; }
    }
}
