using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTesteCS
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() { Nome = "Mactheus", Idade = 21, Nota = 7.6 },
                new Aluno() { Nome = "Carlos", Idade = 18, Nota = 10.0 },
                new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() { Nome = "André", Idade = 21, Nota = 4.3},
                new Aluno() { Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() { Nome = "Jorge", Idade = 20,  Nota = 8.5},
                new Aluno() { Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() { Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() { Nome = "Marcio", Idade = 18, Nota = 2.3 },
                new Aluno() { Nome = "Alex", Idade = 40, Nota = 6.9 }
            };

            var aprovados = alunos.Where(aluno => aluno.Nota >= 7.0).OrderBy(aluno => aluno.Nome);
            foreach (var alunoAprovado in aprovados)
                Console.WriteLine(alunoAprovado.Nome);

            var alunosAprovados = from aluno in alunos where aluno.Nota >= 7 orderby aluno.Idade select aluno.Nome;
        }
    }
}
