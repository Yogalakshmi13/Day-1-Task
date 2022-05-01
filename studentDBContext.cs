using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Stucore.Models
{
    public class studentDBContext:DbContext
    {
        
        public studentDBContext()
        {

        }
        public studentDBContext(DbContextOptions<studentDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LENOVO-PC\\TRAINING;Initial Catalog=Details;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }

        public virtual DbSet<Students> student { get; set; }
    }
}
