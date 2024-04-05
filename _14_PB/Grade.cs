using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PB
{
    internal class Grade
    {
        private int _codigo;
        private string _nome;
        private List<Disciplina> _disciplinas;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        internal List<Disciplina> Disciplinas { get => _disciplinas; set => _disciplinas = value; }

        public Grade(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Disciplinas = new List<Disciplina>();
        }

        public Grade()
        {
            Codigo = 0;
            Nome = "";
            Disciplinas = new List<Disciplina>();
        }

        public override string ToString()
        {
            return "Código: " + Codigo + " / Nome: " + Nome;
        }
    }
}
