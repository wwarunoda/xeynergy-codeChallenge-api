
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using System;
using xeynergy_codeChallenge_api.Entities;

namespace xeynergy_codeChallenge_api.Contexts
{
    public class IdentityDbContext: DbContext
    {
        private readonly IConfigurationRoot _configuration;
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options) 
        {
            _configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AccessRule> AccessRules { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Persons");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder
                .UseSqlServer(_configuration.GetConnectionString("SQLConnection"))
                .LogTo(Console.WriteLine, new[] {RelationalEventId.CommandExecuted})
                .EnableSensitiveDataLogging();
    }
}
