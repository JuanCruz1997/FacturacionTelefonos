using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private double _abono;
        private double _consumoLocal;
        private double _consumoNacional;
        private double _consumoInternacional;
        public Factura(double cl, double cn, double ci)
        {
            _abono = 500;
            this._consumoLocal = cl;
            this._consumoNacional = cn;
            this._consumoInternacional = ci;
        }
        public double Abono { get => _abono; }
        public double ConsumoLocal { get => _consumoLocal; }
        public double ConsumoNacional { get => _consumoNacional; }
        public double ConsumoInternacional { get => _consumoInternacional; }
        public double ConsumoTotal()
        {
            double ct = this._abono + this._consumoLocal + this._consumoNacional + this._consumoInternacional;
            return ct;
        }
    }
}
