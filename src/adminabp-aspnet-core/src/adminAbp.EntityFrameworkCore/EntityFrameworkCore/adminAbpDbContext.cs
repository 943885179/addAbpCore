using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using adminAbp.Authorization.Roles;
using adminAbp.Authorization.Users;
using adminAbp.MultiTenancy;
using adminAbp.Persons;

namespace adminAbp.EntityFrameworkCore
{
    public class adminAbpDbContext : AbpZeroDbContext<Tenant, Role, User, adminAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
       // public DbSet<City> Citys { get; set; } 如果是同样的表的话请创建多个实体

        public adminAbpDbContext(DbContextOptions<adminAbpDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            // modelBuilder.Entity<User>().Ignore(a => a.Name);忽略掉某个字段
            // modelBuilder.Entity<User>().Property(a => a.EmailAddress).IsOptional();设置可空
            //modelBuilder.Entity<Person>().ToTable("Person","PB");
            // modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
