using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeEnergia
{
    public class Calculos
    {
        public double Kw { get; set; }
        public double Talao { get; set; }
        public double Consumo { get; set; }
        public double UltimaLeituraEnergia { get; set; }
        public double LeituraAtualEnergia { get; set; }
        public double UltimaleituraAgua { get; set; }
        public double LeituraAtualAgua { get; set; }

        public double Ckw()
        {
            return Consumo / Talao;
        }
        
        public double ConsumoTotal()
        {
            double ConsumoEnergia = LeituraAtualEnergia - UltimaLeituraEnergia;
            double ConsumoAgua = LeituraAtualAgua - UltimaleituraAgua;
            return ConsumoEnergia + ConsumoAgua;

        }

        public double ValorTotal()
        {
            return ConsumoTotal() * Kw;
        }
    }
}
