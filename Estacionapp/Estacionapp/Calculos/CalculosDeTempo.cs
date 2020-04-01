using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp
{
    public class CalculosDeTempo
    {
        public static double CalcularQuantidadeDeMinutos(Veiculo veiculo)
        {
            return (veiculo.DataHoraSaida - veiculo.DataHoraEntrada).TotalMinutes;
        }

        public static double CalcularQuantidadeDeHoras(Veiculo veiculo)
        {
            return (veiculo.DataHoraSaida - veiculo.DataHoraEntrada).TotalMinutes / 60;
        }

        public static double CalcularQuantidadeDeHorasComDescontoDaPrimeiraHora(Veiculo veiculo)
        {
            return ((veiculo.DataHoraSaida - veiculo.DataHoraEntrada).TotalMinutes - 60) / 60;
        }


    }
}
