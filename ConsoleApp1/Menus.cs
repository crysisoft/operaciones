using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Menus
    {
        int operacion;

        public void Iniciar()
        {

            Console.WriteLine(operacion);
            mostrarMenu();

        }

        static void mostrarMenu()
        {
            Console.WriteLine("############################");
            Console.WriteLine("### Sumar            1   ###");
            Console.WriteLine("### Restar           2   ###");
            Console.WriteLine("### Multiplicar      3   ###");
            Console.WriteLine("### Dividir          4   ###");
            Console.WriteLine("### Salir            5   ###");
            Console.WriteLine("############################");
        }

        private  void leerOperacion()
        {
            Console.WriteLine("Seleccione una opción");
            this.operacion=
        }
    }
}
