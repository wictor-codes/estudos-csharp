using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro_em_POO
{
    internal class Produto_ecommerce_celular
    {
        public string marca;
        public float preco;
        public float potBateria;
        public string processador;
        public string modelo;
        public List<string> ListaDeAcessorios = new List<string>(); 


        public void InformarMarca()
        {
            Console.WriteLine($"A marca do celular é: {marca}");
        }
    }
}
