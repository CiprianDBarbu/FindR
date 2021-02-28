using FindR.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindR.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<CompleteAddress> CompleteAddresses { get; set; }
        public DbSet<Housing> Housings { get; set; }
        public DbSet<PersonalAddress> PersonalAddresses { get; set; }
    }
}
