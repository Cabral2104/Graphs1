using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un grafo con tres vértices (0, 1, 2)
            Dictionary<int, List<int>> grafo = new Dictionary<int, List<int>>();

            grafo[0] = new List<int>(); // Vértice 0
            grafo[1] = new List<int>(); // Vértice 1
            grafo[2] = new List<int>(); // Vértice 2

            // Agregar aristas
            grafo[0].Add(1); // Arista de 0 a 1
            grafo[1].Add(2); // Arista de 1 a 2

            // Mostrar el grafo
            foreach (var par in grafo)
            {
                int vertice = par.Key;
                List<int> vecinos = par.Value;

                Console.Write($"Vértice {vertice} está conectado a: ");
                foreach (var vecino in vecinos)
                {
                    Console.Write($"{vecino} ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
