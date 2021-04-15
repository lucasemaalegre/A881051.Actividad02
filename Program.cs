using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace A881051_.Actividad01
{
    class Program
    {

        static void Main(string[] args)
        {
            int numeroOrden;
            int idOperador;
            int operadorAsignado;

            Queue<int> colaOperadores = new Queue<int>();
            Queue<int> colaOrdenes = new Queue<int>();

            do
            {
                Console.WriteLine("Por favor, registre al operador con su numero Id (Presione 0 para salir)");
                idOperador = int.Parse(Console.ReadLine());

                colaOperadores.Enqueue(idOperador);

            } while (idOperador != 0);

            Console.WriteLine(colaOperadores);


       
            do {
                Console.WriteLine("Por favor, ingrese el numero de orden (Presione 0 para salir)");
                numeroOrden = int.Parse(Console.ReadLine());

                colaOrdenes.Enqueue(numeroOrden);

            } while (numeroOrden != 0);

            Console.WriteLine(colaOrdenes);

            Dictionary<int, int> dicOperadorOden = new Dictionary<int, int>();


            do
            {
                Console.WriteLine("Ingrese el numero de operador para asignarle una orden (Presione 0 para salir)");
                operadorAsignado = int.Parse(Console.ReadLine());

                int ordenEliminada = colaOrdenes.Dequeue();
                dicOperadorOden.Add(operadorAsignado, ordenEliminada);


            } while (operadorAsignado != 0);

            Console.WriteLine("Operarios registrados: " + colaOperadores);
            Console.WriteLine("Pedidos sin asignar: " + colaOrdenes);

            foreach (KeyValuePair<int, int> operario in dicOperadorOden)
            {
                Console.WriteLine($"Estan cargados el operarios Nª{operario.Key} y realizó la orden: {operario.Value}");
            }
        }
    }
}
 