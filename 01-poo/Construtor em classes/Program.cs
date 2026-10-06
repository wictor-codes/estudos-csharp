
namespace construtor_em_classes
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Filme filme = new Filme("V&F", "bom filme", 2008, "Disney");
            Filme filme2 = new Filme("eraDoGelo", "livre", 2003, "DreamWorks");     // essas duas linhas fazem "chamar" o contrutor 2 vezes, assim roda o que tem dentro dele 2 vezes

            Console.WriteLine(filme.nome);
            Console.WriteLine(filme2.ano);
        }
    }

    class Filme
    {
        public string nome;                 // public para conseguir acessas a info fora da classe
        public string descricao;
        public int ano;
        public string studio;

        public Filme(string nome, string descricao, int ano, string studio)   // construtor (não tem retorno, não precisa colocar void)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.ano = ano;
            this.studio = studio;

            Console.WriteLine("Posso fazer comando aqui!");
        }

    }
}
