using EF_priject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_priject.DataAccess
{
    internal class ApplicationDbContext : DbContext
    {
        //هنا احنا بنقوله انا بقدم ورقي عشان ابقي تيبول في الداتا بيز
        public DbSet<Category> categories{ get; set; }
        public DbSet<Product> Products{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFProjrct522;Integrated Security=True;Connect Timeout=30;Encrypt=True;" +
                "Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }
    }
}
