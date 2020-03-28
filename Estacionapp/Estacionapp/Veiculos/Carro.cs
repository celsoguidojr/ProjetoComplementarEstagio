using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp
{
    public class Carro : Veiculo, ICobranca
    {
        public Carro(string placa, DateTime dataHoraEntrada, DateTime dataHoraSaida, double valorPago) : base(placa, dataHoraEntrada, dataHoraSaida, valorPago)
        {
        }

        public double CobrancaAdicionalHora()
        {
            return 1.50;
        }

        public double CobrancaPrimeiraHora()
        {
            return 3;
        }
    }
}
