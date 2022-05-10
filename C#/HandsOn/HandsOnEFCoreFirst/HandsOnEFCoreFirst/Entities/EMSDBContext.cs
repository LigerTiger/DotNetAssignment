using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEFCoreFirst.Entities
{
    class EMSDBContext:DbContext
    {
        //DEFINE THE ENTITY SET
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Project { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // CONGFIGURING THE SQL CONNECTION
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-2QHN0CS5\SQLEXPRESS;Database=EMSDB;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //apply conventions to the Project
            modelBuilder.Entity<Project>(entity =>
            {
                // Set Primary Key 
                entity.HasKey(p => p.ProjectId);// set primary Key
                entity.HasIndex(p => p.ProjectName)
                    .IsUnique(); // Unique Key
                entity.Property(p => p.ProjectId)
                .HasColumnType("varchar")
                .HasMaxLength(30);
                entity.Property(p=>p.ProjectName)
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();

            });
        }
    }
}
