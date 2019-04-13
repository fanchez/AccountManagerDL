using MaestroCuentas.Data;
using MaestroCuentas.Data.Factoria;
using MaestroCuentas.Data.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaestroCuentas.Test
{
    [TestClass]
    public class CuentaTipoData
    {
        private MaestroCuentasDBContext  context;
        public CuentaTipoData()
        {
            var factoria = new MaestroCuentaTiempoDisenoFactoria();
            context = factoria.CreateDbContext(new string[] { });
        }

        [TestMethod]
        public void AddOk()
        {
            int x = 0;
            CuentaTipo cuentaTipo = new CuentaTipo 
            {
                Codigo = "ACT",
                Nombre = "Activos"
            };

            CuentaTipo cuentaTipo2 = new CuentaTipo
            {
                Codigo = "PAS",
                Nombre = "PASIVO"
            };

            context.CuentaTipo.AddRange(cuentaTipo, cuentaTipo2);
            if (context.ChangeTracker.HasChanges())
            { 
                x = context.SaveChanges();
            }
            Assert.AreNotEqual(0, x);
        }
    }
}
