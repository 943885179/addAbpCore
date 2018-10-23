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
       // public DbSet<City> Citys { get; set; } �����ͬ���ı�Ļ��봴�����ʵ��

        public adminAbpDbContext(DbContextOptions<adminAbpDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            // modelBuilder.Entity<User>().Ignore(a => a.Name);���Ե�ĳ���ֶ�
            // modelBuilder.Entity<User>().Property(a => a.EmailAddress).IsOptional();���ÿɿ�
            //modelBuilder.Entity<Person>().ToTable("Person","PB");
            // modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
