using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PB
{
    internal class Disciplina
    {
        private int _codigo;
        private string _nome;
        private List<Grade> _grades;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        internal List<Grade> Grades { get => _grades; set => _grades = value; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Grades = new List<Grade>();
        }

        public Disciplina()
        {
            Codigo = 0;
            Nome = "";
            Grades = new List<Grade>();
        }

        public override string ToString()
        {
            return "Código: " + Codigo + " / Nome: " + Nome;
        }
    }
}
