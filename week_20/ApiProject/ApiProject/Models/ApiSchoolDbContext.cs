using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class ApiSchoolDbContext:DbContext
    {
        public ApiSchoolDbContext(DbContextOptions<ApiSchoolDbContext> options):base(options) { }

        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClassRoom>()
                .HasData(
                    new ClassRoom { Id = 1, Capacity = 30, Name = "Habil" },
                    new ClassRoom { Id = 2, Capacity = 30, Name = "New World" },
                    new ClassRoom { Id = 3, Capacity = 30, Name = "Perfection" },
                    new ClassRoom { Id = 4, Capacity = 30, Name = "My World" }
                );

            modelBuilder.Entity<Teacher>()
                .HasData(
                    new Teacher { Id = 1,FullName="Orkhan Salahov",Email = "orkahan@gmail.com"},
                    new Teacher { Id = 2,FullName="Yagami Light",Email = "yagamikun@gmail.com"},
                    new Teacher { Id = 3,FullName="Eren Yeager",Email = "erenyeager@gmail.com"},
                    new Teacher { Id = 4,FullName="Le Qiye",Email = "@gmail.com"}
                );
        }
    }
}
