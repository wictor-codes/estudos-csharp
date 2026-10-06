using System;
using System.Collections.Generic;
using System.Text;

namespace herança
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public int senha;

        public void Logar()
        {
            Console.WriteLine($"Logando {nome}...");
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Senha: {senha}");
        }

    }
}
