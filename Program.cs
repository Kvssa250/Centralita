using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace _13032023
{
    public abstract class Program
    {
        static void Main(string[] args) 
        {

            Centralita centralita = new Centralita();

            Llamada_local local1 = new Llamada_local("829-383-8359", "809-496-4356", 43);
            centralita.Registrar(local1);

            Llamada_local local2 = new Llamada_local("809-678-3126", "849-653-7984", 83);
            centralita.Registrar(local2);

            Llamada_provincial provincial1 = new Llamada_provincial("829-633-9863", "829-689-4513", 32, 2);
            centralita.Registrar(provincial1);

            Llamada_provincial provincial2 = new Llamada_provincial("849-782-9846", "809-529-6238", 322, 3);
            centralita.Registrar(provincial2);

            Llamada_provincial provincial3 = new Llamada_provincial("809-361-9886", "809-366-7941", 148, 1);
            centralita.Registrar(provincial3);


            centralita.Informe();
        }
    }
}