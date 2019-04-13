using JetBrains.Annotations;
using MaestroCuentas.Data.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaestroCuentas.Data
{
    public class MaestroCuentasDBContext : DbContext
    {
        public MaestroCuentasDBContext(
            DbContextOptions<MaestroCuentasDBContext> options) : base(options)
        {
        }

        public DbSet<CuentaTipo> CuentaTipo { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }

        protected override void OnModelCreating(ModelBuilder Constructor)
        {
            Constructor.Entity<CuentaTipo>().HasKey(r=>r.Id );
            Constructor.Entity<Cuenta>().HasKey(r => r.Id);
            Constructor.Entity<Cuenta>().HasOne(r => r.Cuentatipo ) 
                                        .WithMany(r => r.Cuentas);
        }
    }
}
