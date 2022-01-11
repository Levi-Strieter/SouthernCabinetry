using System;
using Microsoft.EntityFrameworkCore;
using SouthernCabinetry.Models;

namespace SouthernCabinetry.Data
{
    public class SouthernCabinetryContext : DbContext
    {
        public SouthernCabinetryContext(DbContextOptions<SouthernCabinetryContext> options)
            : base(options)
        {
        }

        public DbSet<FinancialOutputs> Movie { get; set; }
    }
}
