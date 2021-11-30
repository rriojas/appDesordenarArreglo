using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDesordenarArreglo
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] cartas = new int[34];
      int[,] tabla = new int[5, 5];

      for (int i = 0; i < cartas.Length ; i++)
      {
        cartas[i] = i+1;
      }
      // Recorrer el arreglo para SWAP - Triangular INTERCAMBIAR un elemento con otro al azar
      Random r = new Random();
      int a, aux;
      for (int i = 0; i < cartas.Length; i++)
      {
        a = r.Next(cartas.Length);
        aux = cartas[i];
        cartas[i] = cartas[a];
        cartas[a] = aux;
      }
      int c = 0;
      //TABLA  de 5 * 5  Llenar
      for (int i = 0; i < tabla.GetLength(0); i++)
      {
        for (int j = 0; j < tabla.GetLength(1); j++)
        {
          tabla[i, j] = cartas[c++];
        }
      }
      //Desordenar tabla
      int ar, ac;
      for (int i = 0; i < tabla.GetLength(0); i++)
      {
        for (int j = 0; j < tabla.GetLength(1); j++)
        {
          ar = r.Next(5);
          ac = r.Next(5);
          aux = tabla[i,j];
          tabla[i,j] = tabla[ar,ac];
          tabla[ar,ac] = aux;
          
        }

      }
      for (int i = 0; i < tabla.GetLength(0); i++)
      {
        for (int j = 0; j < tabla.GetLength(1); j++)
        {
          Console.Write(tabla[i, j] + "\t");
        }
        Console.WriteLine("");
      }

          //for (int i = 0; i < cartas.Length; i++)
          //{
          //  Console.Write(cartas[i] + " ");
          //}
          Console.ReadKey();
     }
  }
}
