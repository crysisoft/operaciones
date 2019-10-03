using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sumar
    {
        public void Iniciar()
        {
            int numeroUno, numeroDos, suma;

            numeroUno = leerNumeroYAsignar();

            numeroDos = leerNumeroYAsignar();

            suma = sumarDosNumeros(numeroUno, numeroDos);

            darSalida(suma);
          
        }

        static void darSalida(int suma)
        {
            Console.WriteLine("La suma es " + suma);
            Console.ReadKey();
        }

        static int leerNumeroYAsignar()
        {
            string valorInicial = "";

            Console.WriteLine("Escriba un número");
            valorInicial = Console.ReadLine();

            return validarNumero(valorInicial);
        }

        static int validarNumero(string valor)
        {
            int numero = 0;
            bool esNumero = int.TryParse(valor, out numero);

            if (esNumero)
            {
                return numero;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERROR:Solo se permiten números enteros ");
                Console.WriteLine("Presione enter para continuar ");
                Console.ReadKey();
                return leerNumeroYAsignar();
            }
        }


        static int sumarDosNumeros(int a, int b)
        {
            return a + b;
        }
    }
}
