using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PB
{
    internal class Aluno
    {
        private int _matricula;
        private string _nome;
        private Curso _curso;

        public int Matricula { get => _matricula; set =>_matricula = value; }
        public string Nome { get => _nome; set => _nome = value; }
        internal Curso Curso { get => _curso; set => _curso = value; }

        public Aluno(int matricula, string nome, Curso curso)
        {
            Matricula = matricula;
            Nome = nome;
            Curso = curso;
        }

        public Aluno()
        {
            Matricula = 0;
            Nome = "";
            Curso = new Curso();
        }

        public override string ToString()
        {
            return "Matrícula: " + Matricula + " / Nome: " + Nome + " / Curso: " + Curso.Nome;
        }
    }
}
