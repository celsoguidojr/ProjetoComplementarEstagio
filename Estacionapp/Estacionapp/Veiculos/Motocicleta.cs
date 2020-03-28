using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp
{
    public class Motocicleta : Veiculo, ICobranca
    {
        public Motocicleta(string placa, DateTime dataHoraEntrada, DateTime dataHoraSaida, double valorPago) : base(placa, dataHoraEntrada, dataHoraSaida, valorPago)
        {
        }

        public double CobrancaAdicionalHora()
        {
            return 1;
        }

        public double CobrancaPrimeiraHora()
        {
            return 1.50;
        }
    }
}
