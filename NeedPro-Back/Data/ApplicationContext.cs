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

        public DbSet<NeedPro_Back.Models.User> User { get; set; }
        public DbSet<NeedPro_Back.Models.City> City { get; set; }
    }
