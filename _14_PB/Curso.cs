using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PB
{
    internal class Curso
    {
        private int _codigo;
        private string _nome;
        private Grade _grade;
        private List<Aluno> _alunos;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        internal Grade Grade { get => _grade; set => _grade = value; }
        internal List<Aluno> Alunos { get => _alunos; set => _alunos = value; }

        public Curso(int codigo, string nome, Grade grade)
        {
            _codigo = codigo;
            _nome = nome;
            _grade = grade;
            Alunos = new List<Aluno>();
        }

        public Curso()
        {
            _codigo = 0;
            _nome = "";
            _grade = new Grade();
            Alunos = new List<Aluno>();
        }

        public string AddAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
            return "Aluno " + aluno.Nome + " adicionado.";
        }

        public string ExibirAlunos()
        {
            string s = "Exibindo alunos que fazem parte do curso " + Nome +":";
            foreach(var aluno in Alunos)
            {
                s += "\n- " + aluno.Nome; 
            }
            return s;
        }

        public string ExibirGrade()
        {
            string s = "Exibindo as disciplinas que fazem parte do curso " + Nome + ":";
            foreach (var disciplina in Grade.Disciplinas)
            {
                s += "\n- " + disciplina.Nome;
            }
            return s;
        }
    }
}
