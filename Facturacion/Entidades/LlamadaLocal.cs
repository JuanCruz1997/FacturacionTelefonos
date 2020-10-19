using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LlamadaLocal
    {
        private double _tarifaHoraPico;
        private double _tarifaNoPico;
        private double _tarifaFinde;
        public LlamadaLocal()
        {
            _tarifaHoraPico = 0.2;
            _tarifaNoPico = 0.1;
            _tarifaFinde = 0.1;
        }
        public double TarifaHoraPico { get => _tarifaHoraPico; }
        public double TarifaNoPico { get => _tarifaNoPico; }
        public double TarifaFinde { get => _tarifaFinde; }
    }
}
