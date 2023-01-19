using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T07.BoardGame.Core.Data
{
    public class BoardGameContext : IdentityDbContext<IdentityUser>
    {
        public BoardGameContext(DbContextOptions<BoardGameContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=THANHNC0711;Database=BoardGameDb;Integrated security=True;Encrypt=false";
            base.OnConfiguring(optionsBuilder);
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RoleSeedConfiguration).Assembly);
        }
    }
}
