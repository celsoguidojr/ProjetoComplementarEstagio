using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp.Interfaces
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }

        double Desconta(Veiculo veiculo);
    }
}
