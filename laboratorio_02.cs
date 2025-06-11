using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_02
{
    internal class Program
    {
            static int[] arreglo = new int[10]; 
            static int indice = 0; 

            static void Main()
            {
                int opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Menú de opciones:");
                    Console.WriteLine("1. Agregar número al arreglo");
                    Console.WriteLine("2. Mostrar el arreglo");
                    Console.WriteLine("3. Imprimir una posición específica");
                    Console.WriteLine("4. Salir");
                    Console.Write("Seleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            AgregarNumero();
                            break;
                        case 2:
                            MostrarArreglo();
                            break;
                        case 3:
                            ImprimirPosicion();
                            break;
                        case 4:
                            Console.WriteLine("¡Hasta luego!");
                            break;
                        default:
                            Console.WriteLine("Opción no válida, intenta de nuevo.");
                            break;
                    }

                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                } while (opcion != 4);
            }

            static void AgregarNumero()
            {
                if (indice < arreglo.Length)
                {
                    Console.Write("Ingrese un número: ");
                    arreglo[indice] = int.Parse(Console.ReadLine());
                    indice++;
                }
                else
                {
                    Console.WriteLine("El arreglo está lleno.");
                }
            }

            
        }
    }
    