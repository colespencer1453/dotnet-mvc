using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ScfContext : DbContext
    {
        public ScfContext(DbContextOptions<ScfContext> options)
            : base(options)
        {
        }

        public DbSet<Case> Cases { get; set; } = default!;
        public DbSet<Visit> Visits { get; set; } = default!;
    }
}
