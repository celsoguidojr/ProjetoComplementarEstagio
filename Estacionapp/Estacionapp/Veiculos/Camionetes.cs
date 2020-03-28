using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionapp
{
    public class Camionetes : Carro, ICobranca
    {
        public Camionetes(string placa, DateTime dataHoraEntrada, DateTime dataHoraSaida, double valorPago) : base(placa, dataHoraEntrada, dataHoraSaida, valorPago)
        {
        }

    }
}
