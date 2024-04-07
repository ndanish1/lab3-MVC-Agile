using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MVCAgile_ProcessWith_Agile.Data
{
    public class MVCAgile_ProcessWith_AgileContext : DbContext
    {
        public MVCAgile_ProcessWith_AgileContext (DbContextOptions<MVCAgile_ProcessWith_AgileContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
