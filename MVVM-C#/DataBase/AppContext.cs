using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVVM.Model;

namespace MVVM.DataBase
{
    public class AppContext: DbContext
    {
        public class ApplicationContext : DbContext
        {
            public DbSet<Recipe> Recipes { get; set; }

            public ApplicationContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MVVMRecipe;Trusted_Connection=True;");
            }
        }
    }
}
