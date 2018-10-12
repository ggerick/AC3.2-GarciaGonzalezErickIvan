using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

public class clasee { }
namespace AC3._GarciaGonzalezErickIvan
{

    class MainClass
    {

        public static void Main(string[] args)
        {
            string[] arreglo = new string[] { "Pepe", "Obama Care", "Conor Mcgregor", "Gamestop" };
            Stack lista = new Stack(arreglo);
            clasee objeto = new clasee();
            Console.WriteLine("Pilas: El ultimo que sale es el primero en salir");
            lista.Push(1);
            lista.Push(2);
            lista.Push(3);
            lista.Push(4);
            lista.Push(5);
            lista.Push(objeto);

            //for (int indice = 0; indice < lista.Count; indice++)
            //{
            //Console.WriteLine("\nValor \t{0} en la posicion \t{1} del tipo \t{2}", lista.Pop(), lista.Count, lista.GetType());
            //}
            int contador = 0;
            foreach (var item in lista)
            {
                Console.WriteLine("\nValor\t'{0}' en la posicion\t{1} del tipo\t {2}", item, contador, item.GetType());
                contador++;
            }



            Console.ReadKey();

        }
    }
}
