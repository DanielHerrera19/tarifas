using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique en que rango se encuentra la hora del dia: ");
            Console.WriteLine("1 :  De 00:00 a 06:59");
            Console.WriteLine("2 :  De 07:00 a 09:59");
            Console.WriteLine("3 :  De 10:00 a 16:59");
            Console.WriteLine("3 :  De 20:00 a 23:59");
            string horadeldiatxt = Console.ReadLine();

            float horadeldia = int.Parse(horadeldiatxt);
            string tarifa;

            switch (horadeldia)
            {
                case 1:
                    tarifa = "Tarifa reducida";
                    break;
                case 2:
                    tarifa = "Tarifa pico";
                    break;
                case 3:
                    tarifa = "Tarifa normal";
                    break;
                case 4:
                    tarifa = "Tarifa noche";
                    break;
                default:
                    tarifa= "Ingrese un rango correcto";
                    break;
            }

            Console.WriteLine(tarifa);
            Console.ReadKey();
        }
    }
}