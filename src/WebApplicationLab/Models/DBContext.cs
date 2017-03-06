using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLab.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
            { }
    }
}
