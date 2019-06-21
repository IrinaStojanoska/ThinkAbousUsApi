using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkAboutApi.Models
{
    public class HomelessDogsContext:DbContext
    {
        public HomelessDogsContext(DbContextOptions<HomelessDogsContext> options):base(options)
        {

        }

        public DbSet<HomelessDogsDetails> HomelessDogs { get; set; }

    }
}
