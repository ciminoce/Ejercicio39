using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double celsius, conversion;
                int opcion;
                Console.Clear();
                Console.WriteLine("Conversión de temperaturas Celsius");
                Console.Write("Ingrese la temperatura en grados celsius:");
                celsius = Convert.ToDouble(Console.ReadLine());
                if (celsius > 15)
                {
                    Console.WriteLine("1-Fahrenheit");
                    Console.WriteLine("2-Reaumur");
                    Console.WriteLine("3-Kelvin");
                    Console.WriteLine("4-Rankine");
                    Console.Write("Ingrese la opción seleccionada:");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion >= 1 && opcion <= 4)
                    {
                        switch (opcion)
                        {
                            case 1:
                                conversion = ConvertiraFahrenheit(celsius);
                                Console.WriteLine($"La conversión a Fah es {conversion}");
                                break;
                            case 2:
                                conversion = ConvertiraReaumur(celsius);
                                Console.WriteLine($"La conversión a Reaumur es {conversion}");
                                break;
                            case 3:
                                conversion = ConvertiraKelvin(celsius);
                                Console.WriteLine($"La conversión a Kelvin es {conversion}");
                                break;
                            default:
                                conversion = ConvertiraRankine(celsius);
                                Console.WriteLine($"La conversión a Rankine es {conversion}");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Opción no válida");
                    }

                }
                else
                {
                    Console.WriteLine("la temperatura debe ser superior a los 15 grados");
                }

            }
            catch (FormatException)
            {

                Console.WriteLine("Número mal ingresado... fin del programa");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Número demasiado grande...Fin del programa");
            }
            Console.ReadLine();
        }

        private static double ConvertiraRankine(double celsius)
        {
            return 1.8 * celsius + 491.67;
        }

        private static double ConvertiraKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        private static double ConvertiraReaumur(double celsius)
        {
            return 0.8 * celsius;
        }

        private static double ConvertiraFahrenheit(double celsius)
        {
            return 1.8 * celsius + 32;
        }
    }
}
