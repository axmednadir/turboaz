using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace turboaz.Models
{
    public partial class turboazContext : DbContext
    {
        public turboazContext()
        {
        }

        public turboazContext(DbContextOptions<turboazContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CategoryMarka> CategoryMarkas { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=WIN-ITTUF10ILP7\\SQLEXPRESS;Database=turboaz;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("car");

                entity.Property(e => e.CarId).HasColumnName("carId");

                entity.Property(e => e.CarDesciption)
                    .HasMaxLength(200)
                    .HasColumnName("carDesciption");

                entity.Property(e => e.CarModel)
                    .HasMaxLength(200)
                    .HasColumnName("carModel");

                entity.Property(e => e.CarQiy).HasColumnName("carQiy");

                entity.Property(e => e.CarSeher).HasMaxLength(200);

                entity.Property(e => e.CarTestiq)
                    .HasMaxLength(30)
                    .HasColumnName("carTestiq");

                entity.Property(e => e.CarUsername)
                    .HasMaxLength(200)
                    .HasColumnName("carUsername");

                entity.Property(e => e.CarcategoryMarkaId).HasColumnName("carcategoryMarkaId");

                entity.HasOne(d => d.CarcategoryMarka)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CarcategoryMarkaId)
                    .HasConstraintName("FK__car__carcategory__3A81B327");
            });

            modelBuilder.Entity<CategoryMarka>(entity =>
            {
                entity.ToTable("categoryMarka");

                entity.Property(e => e.CategoryMarkaId).HasColumnName("categoryMarkaId");

                entity.Property(e => e.CategoryMarkaName)
                    .HasMaxLength(200)
                    .HasColumnName("categoryMarkaName");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.PhotoCar)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.PhotoCarId)
                    .HasConstraintName("FK__Photos__PhotoCar__49C3F6B7");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserActive).HasMaxLength(20);

                entity.Property(e => e.UserDescription).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(20);

                entity.Property(e => e.UserPassword).HasMaxLength(20);

                entity.Property(e => e.UserSurname).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
