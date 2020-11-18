using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NeedPro_Back.Models;

public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<UserSkill>().HasKey(p => new { p.UserId, p.SkillId });
    }

    public DbSet<NeedPro_Back.Models.City> City { get; set; }

    public DbSet<NeedPro_Back.Models.Country> Country { get; set; }

    public DbSet<NeedPro_Back.Models.Domain> Domain { get; set; }

    public DbSet<NeedPro_Back.Models.Skill> Skill { get; set; }

    public DbSet<NeedPro_Back.Models.Speciality> Speciality { get; set; }

    public DbSet<NeedPro_Back.Models.User> User { get; set; }

    public DbSet<NeedPro_Back.Models.UserSkill> UserSkill { get; set; }


}
