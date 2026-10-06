using System;
using System.Collections.Generic;
using System.Text;

namespace interagindo_com_a_internet___JSON
{
    internal class Tarefa
    {
        public int userId, id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine("");
            Console.WriteLine("Objeto Tarefa");
            Console.WriteLine($"User ID: {userId}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Titulo: {title}");
            Console.WriteLine($"Finalizou?: {completed}");
            Console.WriteLine("");
            Console.WriteLine("=========================");
        }
    }
}
