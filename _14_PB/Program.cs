namespace _14_PB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Você pode testar seu programa com apenas cinco alunos e três disciplinas.
            // Instanciando objetos:
            Disciplina d1 = new Disciplina(1, "Java");
            Disciplina d2 = new Disciplina(2, "C#");
            Disciplina d3 = new Disciplina(3, "Projeto de Bloco");

            Grade g1 = new Grade(1, "Back-End 2024");
            g1.Disciplinas.Add(d1);
            g1.Disciplinas.Add(d2);
            g1.Disciplinas.Add(d3);

            Curso c1 = new Curso(1, "Engenharia de Software", g1);

            Aluno aluno1 = new Aluno(1, "Chaves", c1);
            Aluno aluno2 = new Aluno(2, "Chiquinha", c1);
            Aluno aluno3 = new Aluno(3, "Kiko", c1);
            Aluno aluno4 = new Aluno(4, "Madruga", c1);
            Aluno aluno5 = new Aluno(5, "Florinda", c1);

            // Testando o método AddAlunos da classe Curso
            Console.WriteLine("Testando o método AddAlunos da classe Curso\n");
            Console.WriteLine(c1.AddAluno(aluno1));
            Console.WriteLine(c1.AddAluno(aluno2));
            Console.WriteLine(c1.AddAluno(aluno3));
            Console.WriteLine(c1.AddAluno(aluno4));
            Console.WriteLine(c1.AddAluno(aluno5));

            // Testando o método ExibirAlunos
            Console.WriteLine("\n\nTestando o método ExibirAlunos da classe Curso\n");
            Console.WriteLine(c1.ExibirAlunos());

            // Testando o método ExibirGrade
            Console.WriteLine("\n\nTestando o método ExibirGrade da classe Curso\n");
            Console.WriteLine(c1.ExibirGrade());
        }
    }
}
