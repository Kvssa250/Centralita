using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13032023
{
    public abstract class Llamadas
    {
        public string num_origen;
        public string num_destino;
        public double costo_por_segundo = 0;
        public int duracion;

        public Llamadas(string num_origen, string num_destino, int duracion)
        {
            this.num_origen = num_origen;
            this.num_destino = num_destino;
            this.duracion = duracion;
        }

        public virtual double Costo()
        {
            return duracion * costo_por_segundo;
        }
    }
}
