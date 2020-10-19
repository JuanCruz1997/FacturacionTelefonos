using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LlamadasServicio
    {
        private LlamadaLocal ll;
        private LlamadaNacional ln;
        private LlamadaInternacional li;
        public double ObtenerTotalLocal(int minutosPico, int minutosNoPico, int minutosFinde)
        {
            ll = new LlamadaLocal();
            double montoTotal = (minutosPico * ll.TarifaHoraPico) +
                (minutosNoPico * ll.TarifaNoPico) +
                (minutosFinde * ll.TarifaFinde);
            return montoTotal;
        }
        public double ObtenerTotalNacional(int minutosCentro,int minutosLitoral,int minutosNOA,int minutosCuyo,int minutosPatagonia)
        {
            ln = new LlamadaNacional();
            double montoTotal = (minutosCentro * ln.TarifaCentro) +
                (minutosLitoral * ln.TarifaLitoral) +
                (minutosNOA * ln.TarifaNOA) +
                (minutosCuyo * ln.TarifaCuyo) +
                (minutosPatagonia * ln.TarifaPatagonia);
            return montoTotal;
        }
        public double ObtenerTotalInternacional(int minutosLATAM,int minutosNorteamerica,int minutosEuropa, int minutosAfrica,int minutosAsia,int minutosOceania)
        {
            li = new LlamadaInternacional();
            double montoTotal = (minutosLATAM * li.TarifaLATAM) +
                (minutosNorteamerica * li.TarifaNorteamerica) +
                (minutosEuropa * li.TarifaEuropa) +
                (minutosAfrica * li.TarifaAfrica) +
                (minutosAsia * li.TarifaAsia) +
                (minutosOceania * li.TarifaOceania);
            return montoTotal;
        }
    }
}
