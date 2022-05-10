using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LabAssignmentEFCore.Models
{
    public partial class CustomerContext : DbContext
    {
        public CustomerContext()
        {
        }

        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Cust> Custs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-2QHN0CS5\\SQLEXPRESS;Database=Customer;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasKey(e => e.AgentCode)
                    .HasName("PK__Agent__50A79856845FE99E");

                entity.ToTable("Agent");

                entity.HasIndex(e => e.PhoneNo, "UQ__Agent__F3EE33E26E40C14C")
                    .IsUnique();

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AgentCountry)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Commission)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingArea)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cust>(entity =>
            {
                entity.HasKey(e => e.CustCode)
                    .HasName("PK__Cust__4D554DC10FF32FC0");

                entity.ToTable("Cust");

                entity.HasIndex(e => e.PhoneNo, "UQ__Cust__F3EE33E2B26C700E")
                    .IsUnique();

                entity.Property(e => e.CustCode).ValueGeneratedNever();

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CustCity)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustCountry)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingArea)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.AgentCodeNavigation)
                    .WithMany(p => p.Custs)
                    .HasForeignKey(d => d.AgentCode)
                    .HasConstraintName("FK__Cust__AgentCode__3A81B327");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderNo)
                    .HasName("PK__Orders__C3907C7402327A11");

                entity.Property(e => e.OrderNo).ValueGeneratedNever();

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AgentCodeNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AgentCode)
                    .HasConstraintName("FK__Orders__AgentCod__3D5E1FD2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
