using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LlamadaInternacional
    {
        private double _tarifaLATAM;
        private double _tarifaNorteamerica;
        private double _tarifaEuropa;
        private double _tarifaAsia;
        private double _tarifaOceania;
        private double _tarifaAfrica;

        public LlamadaInternacional()
        {
            _tarifaLATAM = 0.5;
            _tarifaNorteamerica = 0.55;
            _tarifaEuropa = 0.6;
            _tarifaAfrica = 0.65;
            _tarifaAsia = 0.7;
            _tarifaOceania = 0.75;
        }

        public double TarifaLATAM { get => _tarifaLATAM; }
        public double TarifaNorteamerica { get => _tarifaNorteamerica; }
        public double TarifaEuropa { get => _tarifaEuropa; }
        public double TarifaAsia { get => _tarifaAsia; }
        public double TarifaAfrica { get => _tarifaAfrica; }
        public double TarifaOceania { get => _tarifaOceania; }
    }
}
