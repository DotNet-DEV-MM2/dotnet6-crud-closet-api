using dotnet6_crud_closet_api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace dotnet6_crud_closet_api.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ClosetItem> ClosetItems { get; set; }
    }
}