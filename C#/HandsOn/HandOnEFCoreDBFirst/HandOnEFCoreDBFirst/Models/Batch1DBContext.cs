using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HandOnEFCoreDBFirst.Models
{
    public partial class Batch1DBContext : DbContext
    {
        public Batch1DBContext()
        {
        }

        public Batch1DBContext(DbContextOptions<Batch1DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public object Employee { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-2QHN0CS5\\SQLEXPRESS;Database=Batch1DB;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.ToTable("dept");

                entity.HasIndex(e => e.DeptName, "UQ__Dept__923D729D9FF7623F")
                    .IsUnique();

                entity.Property(e => e.DeptId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("deptId")
                    .IsFixedLength(true);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("deptName");

                entity.Property(e => e.Location)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("location")
                    .HasDefaultValueSql("('Delhi')");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__AFB3EC0D89BA5C5F");

                entity.ToTable("employee");

                entity.HasIndex(e => e.EmailId, "UQ__Employee__87355E73B164A639")
                    .IsUnique();

                entity.HasIndex(e => e.Mobile, "UQ__Employee__A32E2E1CDCC7D878")
                    .IsUnique();

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("empId");

                entity.Property(e => e.DeptId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("deptId")
                    .IsFixedLength(true);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("emailId");

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("empName");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("date")
                    .HasColumnName("joinDate");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__Employee__deptId__49C3F6B7");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.StudentAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("studentAddress");

                entity.Property(e => e.StudentDob)
                    .HasColumnType("date")
                    .HasColumnName("studentDob");

                entity.Property(e => e.StudentId).HasColumnName("studentId");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("studentName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
