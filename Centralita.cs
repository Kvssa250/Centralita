using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13032023
{
    internal class Centralita
    {
        private List<Llamadas> llamadas = new List<Llamadas>();
        public int cant_llamadas = 0;
        private double costo_total = 0;

        public void Registrar(Llamadas llamada)
        {
            llamadas.Add(llamada);
            cant_llamadas += 1;
            costo_total += llamada switch
            {
                Llamada_local local => local.Costo(),
                Llamada_provincial provincial => provincial.Costo(),
                _ => 0,
            };

            Console.WriteLine("La llamada es desde " + llamada.num_origen + " a " + llamada.num_destino + " con una duracion de (" + llamada.duracion + " segundos)");
            Console.WriteLine("El costo de la llamada es = $" + llamada.Costo() + " DOP");
            Console.WriteLine("");
        }

        public void Informe()
        {
            Console.WriteLine("Cantidad de llamadas: " + cant_llamadas);
            Console.WriteLine("Costo total: " + costo_total.ToString("C") + " DOP ");
        }

    }
}
