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
        public List<Parfum> Parfums { get; set; }
    }

    public class Gender
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public List<Parfum> Parfums { get; set; }
    }

    public class Density
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public List<Parfum> Parfums { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }
        public List<CategoryToParfum> CategoryToParfums { get; set; }
    }

    public class ParfumCnotex : DbContext
    {
        public DbSet<Brend> Brends { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Density> Densities { get; set; }

        public DbSet<SizeML> SizeMLs { get; set; }

        public DbSet<SalePrice> SalePrices { get; set; }

        public DbSet<CategoryToParfum> CategoryToParfums { get; set; }

        public DbSet<Parfum> Parfums { get; set; }

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

            builder.Entity<SizeML>()
                .HasIndex(u => u.Size)
                .IsUnique();

            builder.Entity<Parfum>()
                .HasIndex(t => t.Name)
                .IsUnique();

            builder.Entity<CategoryToParfum>()
                .HasKey(t => new { t.CategoryId, t.ParfumId });

            builder.Entity<CategoryToParfum>()
                .HasOne(cp => cp.Category)
                .WithMany(c => c.CategoryToParfums)
                .HasForeignKey(c => c.CategoryId);

            builder.Entity<CategoryToParfum>()
                .HasOne(cp => cp.Parfum)
                .WithMany(p => p.CategoryToParfums)
                .HasForeignKey(p => p.ParfumId);
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

    public class SizeML
    {
        [Key]
        public int Id { get; set; }

        public double Size { get; set; }
        public List<SalePrice> SalePrices { get; set; }

    }


    public class SalePrice
    {
        [Key]
        public int Id { get; set; }


        public Parfum Parfum { get; set; }
        public int ParfumId { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }


        // Size ML One To Many
        public SizeML SizeML { get; set; }

        public int SizeMLId { get; set; }

    }


    public class Parfum
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public Brend Brend { get; set; }
        public int BrendId { get; set; }


        public Gender Gender { get; set; }
        public int GenderId { get; set; }


        public Density Density { get; set; }
        public int DensityId { get; set; }


        public List<SalePrice> SalePrices { get; set; }

        public List<CategoryToParfum> CategoryToParfums { get; set; }
    }

    public class CategoryToParfum
    {
        public int ParfumId { get; set; }
        public Parfum Parfum { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }

}
