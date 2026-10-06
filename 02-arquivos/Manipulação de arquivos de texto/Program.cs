namespace manipulação_de_arquivos_de_texto
{
    using System.IO;

    internal class Program
    {
        static void Main(string[] args)
        {
            
            StreamWriter escrita = new StreamWriter("testeDeEscrita.txt");  // substitui no arquivo sempre que roda
            escrita.WriteLine("começar");
            escrita.WriteLine("terminar");
            escrita.Close();
            

            StreamWriter escrita2 = File.AppendText("teste2.txt");  // adiciona ao arquivo sempre que roda
            escrita2.WriteLine("gerar");
            escrita2.WriteLine("texto");
            escrita2.Close();
            


            // Leitura

            StreamReader leitura = new StreamReader("testeDeEscrita.txt");
            string conteudo = leitura.ReadToEnd(); // armazenar em uma string
            Console.WriteLine(conteudo);

            Console.WriteLine();
            
            
            string linha = "";                  // leitura com laço
            while (linha != null)
            {
                linha = leitura.ReadLine();
                if (linha != null)
                {
                    Console.WriteLine(linha);
                }
            }
            

            List <string> Linhas = new List<string>();    // leitura com lista
            string Linha = "";
            while (Linha != null)
            {
                Linha = leitura.ReadLine();
                if (Linha != null)
                {
                    Linhas.Add(Linha);
                }
            }
            
            Console.WriteLine(Linhas[0]);   // só uma linha da lista
            
            foreach (string texto in Linhas)   // todas as linhas da lista
            {
                Console.WriteLine(texto);
            }
            
            // NAO FUNCIONA TODOS AO MESMO TEMPO, QUANDO LE DE UM JEITO, NAO TEM MAIS NADA A SER LIDO, ENTAO DA ERRO. PRECISA DEIXAR OS OUTROS MODOS COMO COMENTÁRIO PARA DAR CERTO
        }
    }
}
