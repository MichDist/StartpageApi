using Microsoft.EntityFrameworkCore;
using StartpageApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartpageApi.Data
{
    public class StartpageContext : DbContext
    {
        public StartpageContext(DbContextOptions<StartpageContext> opt) : base(opt)
        {

        }

        // Models
        public DbSet<Link> Links { get; set; }
    }
}
