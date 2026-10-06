using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Projeto__3___Gestor_de_estoque_POO_no_CMD
{
    internal class ProdutoFísico: Produto, IEstoque
    {
        public float frete;
        private int estoque;    // para não ficar de tão facil acesso

        public ProdutoFísico(string nome, float preco, float frete, int estoque = 0)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
            this.estoque = estoque;
        }

        void IEstoque.AdicionarEntrada()
        {
            Console.WriteLine($"====== Adicionar entrada no estoque do produto {nome} ======");
            Console.Write("Digite a quantidade que você quer dar entrada: ");
            int entrada = int.Parse( Console.ReadLine()); 

            estoque += entrada;
            Console.WriteLine("Entrada registrada! Pressione ENTER");
            Console.ReadLine();
        }

        void IEstoque.AdicionarSaida()
        {
            Console.WriteLine($"====== Adicionar saída no estoque do produto {nome} ======");
            Console.Write("Digite a quantidade que você quer dar baixa: ");
            int entrada = int.Parse(Console.ReadLine());

            estoque -= entrada;
            Console.WriteLine("Saída registrada! Pressione ENTER");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("=========================");
        }


        public void Salvar(StreamWriter escrita)                           // salvar no arquivo
        {
            escrita.WriteLine("FÍSICO");
            escrita.WriteLine($"Nome: {nome}");
            escrita.WriteLine($"Frete: {frete}");
            escrita.WriteLine($"Preço: {preco}");
            escrita.WriteLine($"Estoque: {estoque}");
            escrita.WriteLine("=========================");
        }
    }
}
