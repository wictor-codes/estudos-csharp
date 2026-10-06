using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto__3___Gestor_de_estoque_POO_no_CMD
{
    internal class Curso: Produto, IEstoque
    {
        public string autor;
        private int vagas;     // para não ficar de tão facil acesso

        public Curso(string nome, float preco, string autor, int vagas = 0)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
            this.vagas = vagas;
        }

        void IEstoque.AdicionarEntrada()
        {
            Console.WriteLine($"====== Adicionar vagas no curso {nome} ======");
            Console.Write("Digite a quantidade de vagas que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());

            vagas += entrada;
            Console.WriteLine("Entrada registrada! Pressione ENTER");
            Console.ReadLine();
        }

        void IEstoque.AdicionarSaida()
        {
            Console.WriteLine($"====== Consumir vagas no curso {nome} ======");
            Console.Write("Digite a quantidade de vagas que você quer consumir: ");
            int entrada = int.Parse(Console.ReadLine());

            vagas -= entrada;
            Console.WriteLine("Saída registrada! Pressione ENTER");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("=========================");
        }


        public void Salvar(StreamWriter escrita)                                // salvar no arquivo
        {
            escrita.WriteLine("CURSO");
            escrita.WriteLine($"Nome: {nome}");
            escrita.WriteLine($"Autor: {autor}");
            escrita.WriteLine($"Preço: {preco}");
            escrita.WriteLine($"Vagas restantes: {vagas}");
            escrita.WriteLine("=========================");
        }
    }
}
