using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp
{
    public class CalculoDeValores<TTipoVeiculo> where TTipoVeiculo : Veiculo, ICobranca
    {
        private double CalcularValor(TTipoVeiculo veiculo)
        {
            veiculo.ValorAPagar = CalcularValorAPagar(veiculo);
            return  veiculo.ValorAPagar - CalcularDesconto(veiculo);
        }

        private double CalcularDesconto(TTipoVeiculo veiculo)
        {
            var descontoDe15Minutos = new DescontoPorQuinzeMinutos();
            var descontoDeUtilizacao = new DescontoPorNumeroDeUtilizacoes();
            var semDesconto = new SemDesconto();

            descontoDe15Minutos.Proximo = descontoDeUtilizacao;
            descontoDeUtilizacao.Proximo = semDesconto;

            return descontoDe15Minutos.Desconta(veiculo);
        }

        private double CalcularValorAPagar(TTipoVeiculo veiculo)
        {
            if (CalculosDeTempo.CalcularQuantidadeDeHoras(veiculo) <= 1)
                return veiculo.ValorDaPrimeiraHora();

            return veiculo.ValorDaPrimeiraHora() + CalcularValorAdicional(veiculo);
        }

        private double CalcularValorAdicional(TTipoVeiculo veiculo)
        {
            return CalculosDeTempo.CalcularQuantidadeDeHorasComDescontoDaPrimeiraHora(veiculo) * veiculo.ValorDaHoraAdicional();
        }
            
    }
}
