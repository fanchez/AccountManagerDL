using MaestroCuentas.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaestroCuentas.Data.Modelos
{
    public class Cuenta: ModeloBase<int>
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public CuentaTipo Cuentatipo { get; set; }
        public int CuentaTipoId { get; set; }
    }
}
