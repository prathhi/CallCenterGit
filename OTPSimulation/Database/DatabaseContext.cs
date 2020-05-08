using Microsoft.EntityFrameworkCore;
using OTPSimulation.Database.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTPSimulation.Database
{
    public class DatabaseContext :DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FKLNKVA\SQLEXPRESS01;Initial Catalog=CouriersDB;Integrated Security=True");
        }

        
    }
}
