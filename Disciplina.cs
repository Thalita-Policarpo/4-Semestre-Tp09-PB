using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ºSemestre_Tp09_PB
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public Turma Turma { get; set; } // Adicionado para rastrear a turma da disciplina

        public override string ToString()
        {
            return $"Nome: {Nome}, Codigo: {Codigo}";
        }
    }
}
