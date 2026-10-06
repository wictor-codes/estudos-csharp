using System.Runtime.Intrinsics.X86;

namespace structs
{
    internal class Program
    {

        // SEM CONSTRUTOR
        /*
       struct Produto
       {
           public string nome;
           public float preco;
           public float peso;
           public string marca;
       }

       static void Main(string[] args)
       {
           Produto bola = new Produto();
           bola.nome = "bola mágica";
           bola.preco = 100;
           bola.peso = 20;
           bola.marca = "nike";

           Produto garrafa = new Produto();
           garrafa.nome = "garrafa que não vaza";
           garrafa.preco = 50;
           garrafa.peso = 40;
           garrafa.marca = "stanley";

           Console.WriteLine("=========== PRODUTOS ==========");
           Console.WriteLine("Bola - ");
           Console.WriteLine($"Nome: {bola.nome}");
           Console.WriteLine($"Preço: {bola.preco}");
           Console.WriteLine($"Peso: {bola.peso}");
           Console.WriteLine($"Marca: {bola.marca}");
           Console.WriteLine();
           Console.WriteLine("Garrafa - ");
           Console.WriteLine($"Nome: {garrafa.nome}");
           Console.WriteLine($"Preço: {garrafa.preco}");
           Console.WriteLine($"Peso: {garrafa.peso}");
           Console.WriteLine($"Marca: {garrafa.marca}");
       }
        */


        // COM CONSTRUTOR 
        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;

            public Produto(string nome, float preco, float peso, string marca)
            {
                this.nome = nome;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
            }
        }

        static void Main(string[] args)
        {
            Produto bola = new Produto("Bola mágica", 12, 1, "Nike");
            Produto garrafa = new Produto("Garrafa que não vaza", 8, 2, "Stanley");

            Console.WriteLine("=========== PRODUTOS ==========");
            Console.WriteLine("Bola - ");
            Console.WriteLine($"Nome: {bola.nome}");
            Console.WriteLine($"Preço: {bola.preco}");
            Console.WriteLine($"Peso: {bola.peso}");
            Console.WriteLine($"Marca: {bola.marca}");
            Console.WriteLine();
            Console.WriteLine("Garrafa - ");
            Console.WriteLine($"Nome: {garrafa.nome}");
            Console.WriteLine($"Preço: {garrafa.preco}");
            Console.WriteLine($"Peso: {garrafa.peso}");
            Console.WriteLine($"Marca: {garrafa.marca}");
        }
    }
}
