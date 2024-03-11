using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreApp
{
    public class AuthContext : DbContext
    {
        private readonly string _connectionString = "Host=localhost;Port=5432;Username=admin;Password=admin;Database=writeonce";
        //public AuthContext(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
     => options.UseNpgsql(_connectionString);

    }
}
