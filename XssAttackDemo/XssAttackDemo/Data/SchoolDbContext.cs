using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XssAttackDemo.Models;

namespace XssAttackDemo.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

    }
}
