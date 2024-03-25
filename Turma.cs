using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ºSemestre_Tp09_PB
{
    public class Turma
    {
        private List<Aluno> alunos = new List<Aluno>();
        private const int capacidadeMinima = 2; // Capacidade mínima da turma
        private const int capacidadeMaxima = 10; // Capacidade máxima da turma

        public string Codigo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Professor Professor { get; set; }

        // Método para adicionar aluno
        public string AddAluno(Aluno aluno)
        {
            if (alunos.Count < capacidadeMaxima)
            {
                if (!alunos.Contains(aluno))
                {
                    alunos.Add(aluno);
                    aluno.AddTurma(this);
                    return "Aluno adicionado";
                }
                else
                {
                    return "Aluno já está na turma";
                }
            }
            else
            {
                return "Turma cheia";
            }
        }

        // Método para abrir turma
        public bool AbrirTurma()
        {
            return alunos.Count >= capacidadeMinima;
        }

        // Método para gerar pauta
        public string GerarPauta()
        {
            StringBuilder pauta = new StringBuilder($"Código da Turma: {Codigo}\n");
            pauta.AppendLine($"Nome da Disciplina: {Disciplina.Nome}");
            pauta.AppendLine($"Nome do Professor: {Professor.Nome}");
            pauta.AppendLine("Lista de Alunos:");
            foreach (var aluno in alunos)
            {
                pauta.AppendLine(aluno.ToString());
            }
            return pauta.ToString();
        }
    }
}
