using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MonsterPC\SQLEXPRESS; Database=BlogWebApiDb; Trusted_Connection=True");
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
