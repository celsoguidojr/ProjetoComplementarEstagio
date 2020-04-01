using Estacionapp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp
{
    public class DescontoPorNumeroDeUtilizacoes : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Veiculo veiculo)
        {
            if (veiculo.NumeroDeUtilizacoes % 4 == 0)
                return veiculo.ValorAPagar;

            return Proximo.Desconta(veiculo);
        }
    }
}
