using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class ManagerJrContext : DbContext
{
    public DbSet<ManagerJr> ManagerJrs { get; set; }

    public ManagerJrContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Employee_db;Trusted_Connection=True;");
    }
}