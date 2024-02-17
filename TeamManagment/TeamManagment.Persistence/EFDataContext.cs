using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.Entities;

namespace TeamManagment.Persistence
{
    
        public class EFDataContext : DbContext
        {
            public DbSet<Team> Teams { get; set; }
           
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=db1;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
    
}
