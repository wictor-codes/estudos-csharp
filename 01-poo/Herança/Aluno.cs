using System;
using System.Collections.Generic;
using System.Text;

namespace herança
{
    internal class Aluno: Usuario       // herda o que tem em "Usuario"
    {
        public List<string> turma = new List<string>();
        public string turno;
    }
}
