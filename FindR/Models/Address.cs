using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FindR.Models
{
    public enum ZoneType
    {
        Urban,
        Rural
    }
    public class Address
    {
        [Key, Column("AddressId")]
        public int Address_Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public ZoneType Zone { get; set; }

        //many - to - one
        public virtual ICollection<CompleteAddress> CompleteAddresses { get; set; }

    }
}
