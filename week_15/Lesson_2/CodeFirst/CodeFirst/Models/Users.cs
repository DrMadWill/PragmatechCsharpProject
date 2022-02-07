using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirst.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string FullName { get; set; }

        [MaxLength(150)]
        [Required]
        public string Email { get; set; }

        [MaxLength(150)]
        [Required]
        public string Password { get; set; }
        
        public bool IsAdmin { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsUser { get; set; }
        public bool IsActive { get; set; }


    }
    public class Brend
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]

        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class Gender
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
    }

    public class Density
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }
    }

    public class ParfumCnotex : DbContext
    {
        public DbSet<Brend> Brends { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Density> Densities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Brend>()
                .HasIndex(u => u.Name)
                .IsUnique();

            builder.Entity<Gender>()
               .HasIndex(u => u.Name)
               .IsUnique();

            builder.Entity<Category>()
               .HasIndex(u => u.Name)
               .IsUnique();

            builder.Entity<Density>()
               .HasIndex(u => u.Name)
               .IsUnique();

            builder.Entity<User>()
               .HasIndex(u => u.Email)
               .IsUnique();
        }

        public static readonly ILoggerFactory factory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLoggerFactory(factory)
                .UseSqlServer(@"Data Source=LAPTOP-071EH2HU\SQLEXPRESS;Initial Catalog=ParfumDbCodeFirst;"
                + "Integrated Security=true;");

        }

    }
}
