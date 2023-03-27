using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13032023
{
    internal class Llamada_provincial : Llamadas
    {
        private int franja;
        public Llamada_provincial(string num_origen, string num_destino, int duracion, int franja)
            : base(num_origen, num_destino, duracion)
        { 
            this.franja = franja;
        }

        public override double Costo()
        {
            double costo_por_segundo = 0;

            switch (franja)
            {
                case 1:
                    costo_por_segundo = 0.20;
                    break;

                case 2:
                    costo_por_segundo = 0.25;
                    break;

                case 3:
                    costo_por_segundo = 0.30;
                    break;
            }

            return duracion * costo_por_segundo;
        }

    }
}
