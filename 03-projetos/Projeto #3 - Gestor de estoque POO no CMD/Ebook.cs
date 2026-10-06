using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto__3___Gestor_de_estoque_POO_no_CMD
{
    internal class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;         // para não ficar de tão facil acesso

        public Ebook(string nome, float preco, string autor, int vendas = 0)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
            this.vendas = vendas;
        }

        void IEstoque.AdicionarEntrada()
        {
            Console.WriteLine("Não é possível dar entrada no estoque de um Ebook, pois é um produto digital!");
            Console.WriteLine("Para continuar, pressione ENTER");
            Console.ReadLine();
        }

        void IEstoque.AdicionarSaida()
        {
            Console.WriteLine($"====== Adicionar vendas no estoque do produto {nome} ======");
            Console.Write("Digite a quantidade de vendas que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());

            vendas += entrada;
            Console.WriteLine("Saída registrada! Pressione ENTER");
            Console.ReadLine();
        }
            
        public void Exibir()                             // para mostrar no programa
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("=========================");
        }


        public void Salvar(StreamWriter escrita)            // para salvar no arquivo
        {
            escrita.WriteLine("EBOOK");
            escrita.WriteLine($"Nome: {nome}");
            escrita.WriteLine($"Autor: {autor}");
            escrita.WriteLine($"Preço: {preco}");
            escrita.WriteLine($"Vendas: {vendas}");
            escrita.WriteLine("=========================");
        }
    }
}
