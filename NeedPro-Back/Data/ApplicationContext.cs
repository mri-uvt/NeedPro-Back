using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NeedPro_Back.Models;

public partial class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }


   
    public virtual DbSet<Domain> Domain { get; set; }
    public virtual DbSet<Skill> Skill { get; set; }
    public virtual DbSet<Speciality> Speciality { get; set; }
    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<UserSkill> UserSkill { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=NeedPro;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<City>(entity =>
        //{
        //    entity.Property(e => e.Name).HasMaxLength(255);

        //    entity.HasOne(d => d.Country)
        //        .WithMany(p => p.City)
        //        .HasForeignKey(d => d.CountryId)
        //        .HasConstraintName("FK_City_Country");
        //});

        //modelBuilder.Entity<Country>(entity =>
        //{
        //    entity.Property(e => e.Name).HasMaxLength(255);
        //});

        modelBuilder.Entity<Domain>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.Property(e => e.Description).HasMaxLength(255);

            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.Speciality)
                .WithMany(p => p.Skill)
                .HasForeignKey(d => d.SpecialityId)
                .HasConstraintName("FK_Skill_Speciality");
        });

        modelBuilder.Entity<Speciality>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.Domain)
                .WithMany(p => p.Speciality)
                .HasForeignKey(d => d.DomainId)
                .HasConstraintName("FK_Speciality_Domain");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Adress).HasMaxLength(80);

            entity.Property(e => e.Biography).HasMaxLength(150);

            entity.Property(e => e.DateOfBirth)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Email).HasMaxLength(255);

            entity.Property(e => e.FirstName).HasMaxLength(50);

            entity.Property(e => e.LastName).HasMaxLength(50);

            entity.Property(e => e.Pseudo).HasMaxLength(50);

            entity.Property(e => e.Sexe)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.City)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_User_City");

            entity.HasOne(d => d.Speciality)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.SpecialityId)
                .HasConstraintName("FK_User_Speciality");
        });

        modelBuilder.Entity<UserSkill>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.SkillId });

            entity.ToTable("User_Skill");

            entity.HasOne(d => d.Skill)
                .WithMany(p => p.UserSkill)
                .HasForeignKey(d => d.SkillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Skill_Skill");

            entity.HasOne(d => d.User)
                .WithMany(p => p.UserSkill)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Skill_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<NeedPro_Back.Models.Country> Country { get; set; }

    public DbSet<NeedPro_Back.Models.City> City { get; set; }

}

