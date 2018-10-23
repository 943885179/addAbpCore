using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using adminAbp.Authorization.Roles;
using adminAbp.Authorization.Users;
using adminAbp.MultiTenancy;
using adminAbp.Persons;
using Abp.EntityFrameworkCore;
using adminAbp.Citys;

namespace adminAbp.EntityFrameworkCore
{
    public class adminAbpDbContext1 : AbpDbContext
    { 
        /* Define a DbSet for each entity of the application */
        public DbSet<City> Citys { get; set; }
        public adminAbpDbContext1(DbContextOptions<adminAbpDbContext1> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            // modelBuilder.Entity<User>().Ignore(a => a.Name);ºöÂÔµôÄ³¸ö×Ö¶Î
            // modelBuilder.Entity<User>().Property(a => a.EmailAddress).IsOptional();ÉèÖÃ¿É¿Õ
            //modelBuilder.Entity<Person>().ToTable("Person","PB");
            // modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
