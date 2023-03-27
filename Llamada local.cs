using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13032023
{
    internal class Llamada_local : Llamadas
    {
        private double costo_por_segundo = 0.15;

        public Llamada_local(string num_origen, string num_destino, int duracion)
            : base(num_origen, num_destino, duracion)
        { }

        public override double Costo()
        {
            return duracion*costo_por_segundo;
        }

        public string toString()
        { 
            return Costo().ToString();
        }
    }
}
