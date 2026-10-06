using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto__3___Gestor_de_estoque_POO_no_CMD
{
    internal interface IEstoque
    {
        void Exibir();      
        void AdicionarEntrada();
        void AdicionarSaida();
        void Salvar(StreamWriter escrita); // salvar pelo arquivo 'escrita'
    }
}
