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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Address>()
                .HasData(
                    new Address { Address_Id = 1, Country = "Romania", City = "Alba-Iulia", Zone = ZoneType.Urban},
                    new Address { Address_Id = 2, Country = "Romania", City = "Alba-Iulia", Zone = ZoneType.Rural },
                    new Address { Address_Id = 3, Country = "Romania", City = "Alexandria", Zone = ZoneType.Urban },
                    new Address { Address_Id = 4, Country = "Romania", City = "Alexandria", Zone = ZoneType.Rural },
                    new Address { Address_Id = 5, Country = "Romania", City = "Arad", Zone = ZoneType.Urban },
                    new Address { Address_Id = 6, Country = "Romania", City = "Arad", Zone = ZoneType.Rural },
                    new Address { Address_Id = 7, Country = "Romania", City = "Bacau", Zone = ZoneType.Urban },
                    new Address { Address_Id = 8, Country = "Romania", City = "Bacau", Zone = ZoneType.Rural },
                    new Address { Address_Id = 9, Country = "Romania", City = "Baia Mare", Zone = ZoneType.Urban },
                    new Address { Address_Id = 10, Country = "Romania", City = "Baia Mare", Zone = ZoneType.Rural },
                    new Address { Address_Id = 11, Country = "Romania", City = "Bistrita", Zone = ZoneType.Urban },
                    new Address { Address_Id = 12, Country = "Romania", City = "Bistrita", Zone = ZoneType.Rural },
                    new Address { Address_Id = 13, Country = "Romania", City = "Botosani", Zone = ZoneType.Urban },
                    new Address { Address_Id = 14, Country = "Romania", City = "Botosani", Zone = ZoneType.Rural },
                    new Address { Address_Id = 15, Country = "Romania", City = "Brasov", Zone = ZoneType.Urban },
                    new Address { Address_Id = 16, Country = "Romania", City = "Brasov", Zone = ZoneType.Rural },
                    new Address { Address_Id = 17, Country = "Romania", City = "Braila", Zone = ZoneType.Urban },
                    new Address { Address_Id = 18, Country = "Romania", City = "Braila", Zone = ZoneType.Rural },
                    new Address { Address_Id = 19, Country = "Romania", City = "Buzau", Zone = ZoneType.Urban },
                    new Address { Address_Id = 20, Country = "Romania", City = "Buzau", Zone = ZoneType.Rural },
                    new Address { Address_Id = 21, Country = "Romania", City = "Calarasi", Zone = ZoneType.Urban },
                    new Address { Address_Id = 22, Country = "Romania", City = "Calarasi", Zone = ZoneType.Rural },
                    new Address { Address_Id = 23, Country = "Romania", City = "Cluj-Napoca", Zone = ZoneType.Urban },
                    new Address { Address_Id = 24, Country = "Romania", City = "Cluj-Napoca", Zone = ZoneType.Rural },
                    new Address { Address_Id = 25, Country = "Romania", City = "Constanta", Zone = ZoneType.Urban },
                    new Address { Address_Id = 26, Country = "Romania", City = "Constanta", Zone = ZoneType.Rural },
                    new Address { Address_Id = 27, Country = "Romania", City = "Craiova", Zone = ZoneType.Urban },
                    new Address { Address_Id = 28, Country = "Romania", City = "Craiova", Zone = ZoneType.Rural },
                    new Address { Address_Id = 29, Country = "Romania", City = "Deva", Zone = ZoneType.Urban },
                    new Address { Address_Id = 30, Country = "Romania", City = "Deva", Zone = ZoneType.Rural },
                    new Address { Address_Id = 31, Country = "Romania", City = "Drobeta-Turnu-Severin", Zone = ZoneType.Urban },
                    new Address { Address_Id = 32, Country = "Romania", City = "Drobeta-Turnu-Severin", Zone = ZoneType.Rural },
                    new Address { Address_Id = 33, Country = "Romania", City = "Focsani", Zone = ZoneType.Rural },
                    new Address { Address_Id = 34, Country = "Romania", City = "Focsani", Zone = ZoneType.Urban },
                    new Address { Address_Id = 35, Country = "Romania", City = "Galati", Zone = ZoneType.Rural },
                    new Address { Address_Id = 36, Country = "Romania", City = "Galati", Zone = ZoneType.Urban },
                    new Address { Address_Id = 37, Country = "Romania", City = "Giurgiu", Zone = ZoneType.Rural },
                    new Address { Address_Id = 38, Country = "Romania", City = "Giurgiu", Zone = ZoneType.Urban },
                    new Address { Address_Id = 39, Country = "Romania", City = "Iasi", Zone = ZoneType.Rural },
                    new Address { Address_Id = 40, Country = "Romania", City = "Iasi", Zone = ZoneType.Urban },
                    new Address { Address_Id = 41, Country = "Romania", City = "Miercurea-Ciuc", Zone = ZoneType.Rural },
                    new Address { Address_Id = 42, Country = "Romania", City = "Miercurea-Ciuc", Zone = ZoneType.Urban },
                    new Address { Address_Id = 43, Country = "Romania", City = "Oradea", Zone = ZoneType.Rural },
                    new Address { Address_Id = 44, Country = "Romania", City = "Oradea", Zone = ZoneType.Urban },
                    new Address { Address_Id = 45, Country = "Romania", City = "Piatra Neamt", Zone = ZoneType.Rural },
                    new Address { Address_Id = 46, Country = "Romania", City = "Piatra Neamt", Zone = ZoneType.Urban },
                    new Address { Address_Id = 47, Country = "Romania", City = "Pitesti", Zone = ZoneType.Rural },
                    new Address { Address_Id = 48, Country = "Romania", City = "Pitesti", Zone = ZoneType.Urban },
                    new Address { Address_Id = 49, Country = "Romania", City = "Ploiesti", Zone = ZoneType.Rural },
                    new Address { Address_Id = 50, Country = "Romania", City = "Ploiesti", Zone = ZoneType.Urban },
                    new Address { Address_Id = 51, Country = "Romania", City = "Ramnicu Valcea", Zone = ZoneType.Rural },
                    new Address { Address_Id = 52, Country = "Romania", City = "Ramnicu Valcea", Zone = ZoneType.Urban },
                    new Address { Address_Id = 53, Country = "Romania", City = "Resita", Zone = ZoneType.Rural },
                    new Address { Address_Id = 54, Country = "Romania", City = "Resita", Zone = ZoneType.Urban },
                    new Address { Address_Id = 55, Country = "Romania", City = "Satu Mare", Zone = ZoneType.Rural },
                    new Address { Address_Id = 56, Country = "Romania", City = "Satu Mare", Zone = ZoneType.Urban },
                    new Address { Address_Id = 57, Country = "Romania", City = "Sfantu Gheorghe", Zone = ZoneType.Rural },
                    new Address { Address_Id = 58, Country = "Romania", City = "Sfantu Gheorghe", Zone = ZoneType.Urban },
                    new Address { Address_Id = 59, Country = "Romania", City = "Sibiu", Zone = ZoneType.Rural },
                    new Address { Address_Id = 60, Country = "Romania", City = "Sibiu", Zone = ZoneType.Urban },
                    new Address { Address_Id = 61, Country = "Romania", City = "Slatina", Zone = ZoneType.Rural },
                    new Address { Address_Id = 62, Country = "Romania", City = "Slatina", Zone = ZoneType.Urban },
                    new Address { Address_Id = 63, Country = "Romania", City = "Slobozia", Zone = ZoneType.Rural },
                    new Address { Address_Id = 64, Country = "Romania", City = "Slobozia", Zone = ZoneType.Urban },
                    new Address { Address_Id = 65, Country = "Romania", City = "Suceava", Zone = ZoneType.Urban },
                    new Address { Address_Id = 66, Country = "Romania", City = "Suceava", Zone = ZoneType.Rural },
                    new Address { Address_Id = 67, Country = "Romania", City = "Targoviste", Zone = ZoneType.Urban },
                    new Address { Address_Id = 68, Country = "Romania", City = "Targoviste", Zone = ZoneType.Rural },
                    new Address { Address_Id = 69, Country = "Romania", City = "Targu Jiu", Zone = ZoneType.Urban },
                    new Address { Address_Id = 70, Country = "Romania", City = "Targu Jiu", Zone = ZoneType.Rural },
                    new Address { Address_Id = 71, Country = "Romania", City = "Targu Mures", Zone = ZoneType.Urban },
                    new Address { Address_Id = 72, Country = "Romania", City = "Targu Mures", Zone = ZoneType.Rural },
                    new Address { Address_Id = 73, Country = "Romania", City = "Timisoara", Zone = ZoneType.Urban },
                    new Address { Address_Id = 74, Country = "Romania", City = "Timisoara", Zone = ZoneType.Rural },
                    new Address { Address_Id = 75, Country = "Romania", City = "Tulcea", Zone = ZoneType.Urban },
                    new Address { Address_Id = 76, Country = "Romania", City = "Tulcea", Zone = ZoneType.Rural },
                    new Address { Address_Id = 77, Country = "Romania", City = "Vaslui", Zone = ZoneType.Urban },
                    new Address { Address_Id = 78, Country = "Romania", City = "Vaslui", Zone = ZoneType.Rural },
                    new Address { Address_Id = 79, Country = "Romania", City = "Zalau", Zone = ZoneType.Rural },
                    new Address { Address_Id = 80, Country = "Romania", City = "Zalau", Zone = ZoneType.Urban },
                    new Address { Address_Id = 81, Country = "Romania", City = "Bucuresti, Sector1", Zone = ZoneType.Urban },
                    new Address { Address_Id = 82, Country = "Romania", City = "Bucuresti, Sector2", Zone = ZoneType.Urban },
                    new Address { Address_Id = 83, Country = "Romania", City = "Bucuresti, Sector3", Zone = ZoneType.Urban },
                    new Address { Address_Id = 84, Country = "Romania", City = "Bucuresti, Sector4", Zone = ZoneType.Urban },
                    new Address { Address_Id = 85, Country = "Romania", City = "Bucuresti, Sector5", Zone = ZoneType.Urban },
                    new Address { Address_Id = 86, Country = "Romania", City = "Bucuresti, Sector6", Zone = ZoneType.Urban },
                    new Address { Address_Id = 87, Country = "Romania", City = "Bucuresti", Zone = ZoneType.Rural }
                    );
            
        }
    }


}
