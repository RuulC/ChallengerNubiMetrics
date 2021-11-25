using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChallengerNubiMetrics.Models;

namespace ChallengerNubiMetrics.Data
{
    public class ChallengerNubiMetricsContext : DbContext
    {
        public ChallengerNubiMetricsContext (DbContextOptions<ChallengerNubiMetricsContext> options)
            : base(options)
        {
        }

        public DbSet<ChallengerNubiMetrics.Models.Usuarios> Usuarios { get; set; }
    }
}
