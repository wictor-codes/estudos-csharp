using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criação da lista
            List <string> clientes = new List <string> ();
            clientes.Add("wictor");
            clientes.Add("Ana");
            string pessoa = "José";
            clientes.Add(pessoa);

            // busca de elementos da lista por indice
            Console.WriteLine(clientes[0]);

            // contagem de elementos
            Console.WriteLine(clientes.Count);


            // busca de elementos por dados
            string busca = clientes.Find(x => x == "José");
            Console.WriteLine(busca);

            Console.WriteLine();

            List <string> busca2 = clientes.FindAll(cliente => cliente.Length < 5);
            Console.WriteLine(string.Join(",", busca2)); // tranformar lista em uma linha so - string.Join(separador, lista) 
            
            // ou
            foreach (string cliente in busca2)
            {
                Console.WriteLine(cliente);
                
                if (busca2 == null)
                {
                    Console.WriteLine("Não achou!");
                }
            }


            Console.WriteLine();


            // todos os elementos da lista
            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine();


            // remover elemento por indice
            clientes.RemoveAt(2);
            foreach(string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine();

            // remover elemento por dados
            clientes.RemoveAll(cliente => cliente == "Ana");
            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

        }
    }
}
