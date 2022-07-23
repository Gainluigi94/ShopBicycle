using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Model.Classes
{
    public partial class BikeContext : DbContext
    {
        public BikeContext()
        {
        }

        public BikeContext(DbContextOptions<BikeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Bike> Bikes { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Shopping> Shoppings { get; set; }
        public virtual DbSet<Userr> Userrs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=GIANLUIGI\\SQLEXPRESS;database=Bikes;User id=sa;password=Bilancia94;Persist Security Info=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Idaddress);

                entity.ToTable("Address");

                entity.Property(e => e.Common)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sidestreet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Way)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bike>(entity =>
            {
                entity.HasKey(e => e.BiciId)
                    .HasName("PK__Bike__BD989B4522EE2836");

                entity.ToTable("Bike");

                entity.Property(e => e.BiciId).ValueGeneratedNever();

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Wheel).HasColumnName("wheel");
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.ToTable("CreditCard");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Expiration).HasColumnType("date");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => new { e.Email, e.Passwordd });

                entity.ToTable("Person");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passwordd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birth).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Taxcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bici)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.BiciId)
                    .HasConstraintName("FK_Person_Bike");
            });

            modelBuilder.Entity<Shopping>(entity =>
            {
                entity.ToTable("Shopping");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bici)
                    .WithMany(p => p.Shoppings)
                    .HasForeignKey(d => d.BiciId)
                    .HasConstraintName("FK__Shopping__BiciId__30F848ED");
            });

            modelBuilder.Entity<Userr>(entity =>
            {
                entity.ToTable("Userr");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passwordd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Userrs)
                    .HasForeignKey(d => new { d.Email, d.Passwordd })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Userr_Person");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
