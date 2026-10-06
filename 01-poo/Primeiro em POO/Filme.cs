using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro_em_POO
{
    internal class Filme // o dele tava sem esse "internal"
    {
        public string nome;
        public string descricao;
        public int ano;
        public string studio;
        public List<string> atores = new List<string>();

        public void Executar()          // método (função dentro de classe)
        {
            Console.WriteLine($"Rodando filme: {nome}");
        }

        public void Pausar()            // método
        {
            Console.WriteLine("||");
        }

    }
}
