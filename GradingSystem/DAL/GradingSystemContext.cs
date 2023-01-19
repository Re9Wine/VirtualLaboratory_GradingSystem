using Domain.Entity;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL
{
    public partial class GradingSystemContext : DbContext
    {
        public GradingSystemContext()
        {
        }

        public GradingSystemContext(DbContextOptions<GradingSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LaboratoryWork> LaboratoryWorks { get; set; }
        public virtual DbSet<Report> Reports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-RTPDA1J;Database=GradingSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<LaboratoryWork>(entity =>
            {
                entity.ToTable("LaboratoryWork");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.IdLaboratoryWork).HasColumnName("Id_LaboratoryWork");

                entity.HasOne(d => d.IdLaboratoryWorkNavigation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.IdLaboratoryWork)
                    .HasConstraintName("FK_Report_LaboratoryWork");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
