using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp
{
    public class Veiculo
    {
        public string Placa { get; private set; }

        public DateTime DataHoraEntrada { get; private set; }

        public DateTime DataHoraSaida { get; private set; }

        public double ValorPago { get; private set; }

        public Veiculo(string placa, DateTime dataHoraEntrada, DateTime dataHoraSaida, double valorPago)
        {
            Placa = placa;
            DataHoraEntrada = dataHoraEntrada;
            DataHoraSaida = dataHoraSaida;
            ValorPago = valorPago;
        }

        public double CalcularTempo()
        {
            return (DataHoraSaida - DataHoraEntrada).TotalMinutes;
        }
    }
}
