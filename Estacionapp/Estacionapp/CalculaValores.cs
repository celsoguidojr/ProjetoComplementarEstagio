using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp
{
    public class CalculaValores<TTipoVeiculo> where TTipoVeiculo : Veiculo, ICobranca
    {
        private double CalcularValor(TTipoVeiculo veiculo)
        {
            var valorAPagar = veiculo.CalcularTempo() < 15 ? 0 : (veiculo.CalcularTempo() / 60) * veiculo.CobrancaPrimeiraHora();
            return valorAPagar;
        }

        private double CalcularValorAdicional(TTipoVeiculo veiculo)
        {
            return ((veiculo.CalcularTempo() % 60)/60) * veiculo.CobrancaAdicionalHora();
        }
    }
}
