using System.Reflection;

namespace driblar_encapsulamento__private_
{


    internal class Program
    {
         // public permite acesso a info fora da classe, private não permite
        static void Main(string[] args)
        {
            Filme filme = new Filme();
            Filme filme2 = new Filme();

            filme.AddAtor("Bradd Pitt");            // não acessou a lista diretamente (não é public), e sim pelo intermediador
            filme.AddAtor("Tom Holland");
            filme.AddAtor("Den");                   // menor que 4
            filme.AddAtor(null);                    // null
            filme.AddAtor("Zendaya");
            filme.ExibirAtores();

            Console.WriteLine("==================");

            filme.RemoveAtor("Bradd Pitt");
            filme.ExibirAtores();

            Console.WriteLine("==================");

            filme.LimparListaAtores();
            filme.ExibirAtores();

            Console.WriteLine("==================");

        }
    }


    class Filme
    { 
        private List<string> atores = new List<string>();

        public void AddAtor(string nome)
        {
            if (nome != null)
            {
                if (nome.Length > 4)                // se atender essas restrições, entra na lista (filtragem), ainda mantendo a lista privada, impedindo adicionar coisa errada por qualquer arquivo
                {
                    atores.Add(nome);
                }
            }
        }


        public void RemoveAtor(string nome)
        {
            if (nome != null)
            {
                if (nome.Length > 4)                // remover nome da lista
                {
                    atores.Remove(nome);
                }
            }
        }


         public void LimparListaAtores()
         {                                          // limpar a lista
            atores.Clear();
         }


        public void ExibirAtores()
        {
            foreach (string ator in atores)         // exibir os nomes
            {
                Console.WriteLine(ator);
            }
        }

    }

}
