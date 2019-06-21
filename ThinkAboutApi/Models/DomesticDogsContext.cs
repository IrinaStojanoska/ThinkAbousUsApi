using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkAboutApi.Models
{
    public class DomesticDogsContext: DbContext
    {
        public DomesticDogsContext(DbContextOptions<DomesticDogsContext> options) : base(options)
        {

        }

        public DbSet<DomesticDogsDetails> DomesticDogs { get; set; }
    }
}
