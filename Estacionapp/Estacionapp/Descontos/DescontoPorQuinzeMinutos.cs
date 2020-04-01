using Estacionapp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp
{
    public class DescontoPorQuinzeMinutos : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Veiculo veiculo)
        {
            if(CalculosDeTempo.CalcularQuantidadeDeMinutos(veiculo) < 15)
            {
                return veiculo.ValorAPagar;
            }

             return Proximo?.Desconta(veiculo) ?? 0;
        }
    }
}
