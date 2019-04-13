using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaestroCuentas.Data.Factoria
{
    public class MaestroCuentaTiempoDisenoFactoria : IDesignTimeDbContextFactory<MaestroCuentasDBContext>
    {
        public MaestroCuentasDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MaestroCuentasDBContext >();
            optionsBuilder.UseSqlServer(@"Server=PC-FSANCHEZ\SQL2008R2;Database=fsMaestroCuenta;Integrated Security=true;");
            return new MaestroCuentasDBContext (optionsBuilder.Options);
        }
    }
}
