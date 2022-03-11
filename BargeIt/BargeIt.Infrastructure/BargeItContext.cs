using BargeIt.Config;
using BargeIt.Domain.AggregatesModel.CompanyAggregate;
using BargeIt.Domain.AggregatesModel.CargoAggregate;
using BargeIt.Domain.AggregatesModel.PortAggregate;
using BargeIt.Domain.SeedWork;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace BargeIt.Infrastructure
{
    public class BargeItContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public BargeItContext() { }

        public BargeItContext(DbContextOptions<BargeItContext> options)
            : base(options)
        { }

        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        //public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        //public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        //public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        //public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Claim> Claim { get; set; }
        public DbSet<Container> Container { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Barge> Barge { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Port> Port { get; set; }
        public DbSet<Terminal> Terminal { get; set; }
        public DbSet<Quay> Quay { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(BargeItContext)));

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json",
                    optional: false,
                    reloadOnChange: true)
                .AddJsonFile($"appsettings.{envName}.json",
                    optional: true,
                    reloadOnChange: true)
                .Build();

            var bargeItConfig = builder.GetSection("BargeIt")
                .Get<BargeItConfig>();

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(bargeItConfig.ConnectionString);
            }
        }

        public override int SaveChanges()
        {
            AddAuditInfo();
            HandleEnumerationModels();

            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            AddAuditInfo();
            HandleEnumerationModels();

            return await base.SaveChangesAsync();
        }

        private void AddAuditInfo()
        {
            foreach (var entry in ChangeTracker.Entries<ITrackableEntity>())
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.IsModified();
                }

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.IsCreated();
                }
                else
                {
                    entry.Property(p => p.Created).IsModified = false;
                }
            }
        }

        private void HandleEnumerationModels()
        {
            foreach (var entry in ChangeTracker.Entries<IEnumeration>())
            {
                entry.State = EntityState.Unchanged;
            }
        }

    }
}
