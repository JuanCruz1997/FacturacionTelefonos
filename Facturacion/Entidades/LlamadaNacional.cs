using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LlamadaNacional
    {
        private double _tarifaPatagonia;
        private double _tarifaCuyo;
        private double _tarifaNOA;
        private double _tarifaLitoral;
        private double _tarifaCentro;

        public LlamadaNacional()
        {
            _tarifaCentro = 0.25;
            _tarifaLitoral = 0.30;
            _tarifaNOA = 0.35;
            _tarifaCuyo = 0.40;
            _tarifaPatagonia = 0.45;
        }

        public double TarifaPatagonia { get => _tarifaPatagonia; }
        public double TarifaCuyo { get => _tarifaCuyo; }
        public double TarifaNOA { get => _tarifaNOA; }
        public double TarifaLitoral { get => _tarifaLitoral; }
        public double TarifaCentro { get => _tarifaCentro; }
    }
}
