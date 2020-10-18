using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FacturaServicio
    {
        public double TotalFactura(Factura f)
        {
            double totalFactura = f.ConsumoTotal();
            return totalFactura;
        }
    }
}
