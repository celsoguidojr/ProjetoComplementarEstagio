using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp
{
    public interface ICobranca
    {
        double ValorDaPrimeiraHora();
        double ValorDaHoraAdicional();
    }
}
