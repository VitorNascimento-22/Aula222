using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Aula222.Models
{
    public class Aula222Context : DbContext
    {
        public Aula222Context (DbContextOptions<Aula222Context> options)
            : base(options)
        {
        }

        public DbSet<Aula222.Models.Department> Department { get; set; }
    }
}
