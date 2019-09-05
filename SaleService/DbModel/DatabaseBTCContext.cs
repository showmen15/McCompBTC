using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SaleService.DbModel
{
    public partial class DatabaseBTCContext : DbContext
    {
        public DatabaseBTCContext()
        {
        }

        public DatabaseBTCContext(DbContextOptions<DatabaseBTCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RegisterUsers> RegisterUsers { get; set; }
        public virtual DbSet<RegisterUsersEmails> RegisterUsersEmails { get; set; }
        public virtual DbSet<RegisterUsersPhones> RegisterUsersPhones { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<ValidationCodes> ValidationCodes { get; set; }
        public virtual DbSet<Wallet> Wallet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=DatabaseBTC;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<RegisterUsers>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__Register__B7C926387F60ED59");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RegisterUsersEmails>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__Register__B7C9263803317E3D");

                entity.Property(e => e.IdUser).ValueGeneratedNever();

                entity.Property(e => e.Email).IsRequired();

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.RegisterUsersEmails)
                    .HasForeignKey<RegisterUsersEmails>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterUsersEmails_RegisterUsers");
            });

            modelBuilder.Entity<RegisterUsersPhones>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__Register__B7C9263807020F21");

                entity.Property(e => e.IdUser).ValueGeneratedNever();

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.RegisterUsersPhones)
                    .HasForeignKey<RegisterUsersPhones>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterUsersPhones_RegisterUsers");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.Property(e => e.Btc).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<ValidationCodes>(entity =>
            {
                entity.HasKey(e => e.IdCode)
                    .HasName("PK__Validati__37DBAFC60EA330E9");
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.HasKey(e => e.IdWallet)
                    .HasName("PK__Wallet__321BF1751273C1CD");

                entity.Property(e => e.IdWallet).ValueGeneratedNever();

                entity.Property(e => e.AdressName)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
