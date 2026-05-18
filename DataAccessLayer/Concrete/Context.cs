using EntityLayer.Conctrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=DbNewOopCore3;Integrated Security=true;TrustServerCertificate=True;");
        }
        public DbSet<Product> Products {  get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Job> Jobs { get; set; }
    }
}
