namespace structs_e_funções
{
    internal class Program
    {

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

            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {this.nome}");
                Console.WriteLine($"Preço: {this.preco}");
                Console.WriteLine($"Peso: {this.peso} kg");
                Console.WriteLine($"Marca: {this.marca}");
            }

            public float AdicionarCupom (float porcentagem)
            {
                float desconto = this.preco * porcentagem / 100;
                return this.preco - desconto;
            }
        }

        static void Main(string[] args)
        {
            Produto estojo = new Produto("estojo vermelho", 30, 4, "puma");
            Produto computador = new Produto("computador gamer", 8000, 7, "pichau");

            estojo.ExibirInfo();
            computador.ExibirInfo();

            float valorFinalEstojo = estojo.AdicionarCupom(50);
            float valorFinalComp = computador.AdicionarCupom(50);
            Console.WriteLine($"{valorFinalEstojo} reais\n{valorFinalComp} reais");
        }
    }
}
