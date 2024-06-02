using Core.Entytys;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context
{
    public class BookingContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public BookingContext(DbContextOptions<BookingContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
        }
        public DbSet<Apartaments> Actors => Set<Apartaments>();
        public DbSet<InformationAboutApartment> Cinemas => Set<InformationAboutApartment>();
        public DbSet<ServiceProviderr> Directors => Set<ServiceProviderr>();
   
       
    }
}
