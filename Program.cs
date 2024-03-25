namespace _4ºSemestre_Tp09_PB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de listas
            List<Turma> turmas = new List<Turma>();
            List<Professor> professores = new List<Professor>();
            List<Disciplina> disciplinas = new List<Disciplina>();
            List<Aluno> alunos = new List<Aluno>();

            // Criação de alunos
            Aluno aluno1 = new Aluno { Nome = "João", Matricula = "123" };
            Aluno aluno2 = new Aluno { Nome = "Maria", Matricula = "456" };
            Aluno aluno3 = new Aluno { Nome = "Pedro", Matricula = "789" };
            alunos.AddRange(new[] { aluno1, aluno2, aluno3 });

            // Criação de disciplina
            Disciplina disciplina1 = new Disciplina { Nome = "Matemática", Codigo = "MAT101" };
            Disciplina disciplina2 = new Disciplina { Nome = "Português", Codigo = "POR101" };
            disciplinas.AddRange(new[] { disciplina1, disciplina2 });

            // Criação de professor
            Professor professor1 = new Professor { Nome = "Carlos", Matricula = "789" };
            Professor professor2 = new Professor { Nome = "Ana", Matricula = "321" };
            professores.AddRange(new[] { professor1, professor2 });

            // Criação de turma
            Turma turma1 = new Turma { Codigo = "TURMA1", Disciplina = disciplina1, Professor = professor1 };
            Turma turma2 = new Turma { Codigo = "TURMA2", Disciplina = disciplina2, Professor = professor2 };
            turmas.AddRange(new[] { turma1, turma2 });

            // Adicionando alunos à turma1
            Console.WriteLine(turma1.AddAluno(aluno1));
            Console.WriteLine(turma1.AddAluno(aluno2));
            Console.WriteLine(turma1.AddAluno(aluno1)); // Testando adicionar o mesmo aluno novamente

            // Adicionando alunos à turma2
            Console.WriteLine(turma2.AddAluno(aluno2));
            Console.WriteLine(turma2.AddAluno(aluno3));
            Console.WriteLine(turma2.AddAluno(aluno2)); // Testando adicionar o mesmo aluno novamente

            // Tentando abrir as turmas
            Console.WriteLine($"A turma1 pode ser aberta? {turma1.AbrirTurma()}");
            Console.WriteLine($"A turma2 pode ser aberta? {turma2.AbrirTurma()}");

            // Gerando a pauta das turmas
            Console.WriteLine(turma1.GerarPauta());
            Console.WriteLine(turma2.GerarPauta());

            // Exibindo as turmas dos alunos
            Console.WriteLine($"Turmas do aluno {aluno1.Nome}: {aluno1.ExibirTurmas()}");
            Console.WriteLine($"Turmas do aluno {aluno2.Nome}: {aluno2.ExibirTurmas()}");
            Console.WriteLine($"Turmas do aluno {aluno3.Nome}: {aluno3.ExibirTurmas()}");
        }
    }

}
