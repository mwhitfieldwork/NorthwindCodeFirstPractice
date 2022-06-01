using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NWDotNetCore.Models
{
    public class ApplicationDbContext : DbContext // inherits from db context class ( dont forget)
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Categories> Categories { get; set; }// To add a table to the code first db, add it here
        public DbSet<Employees> Employees { get; set; }
    }
}
