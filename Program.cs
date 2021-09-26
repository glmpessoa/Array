using System;

namespace arraycolection
{
    class Program
    {
        static void Main(string[] args)
        {
          string [] alunos = new string [5]  {
              "guilherme",
              "bruno",
              "pedro",
              "joao",
              "lucas"
          };

          Console.WriteLine(alunos[2]);

          alunos[2] = "Maria";

         Console.WriteLine($"o novo valor do index 2 {alunos[2]}");

           foreach (string aluno in alunos)
           {
               Console.WriteLine(aluno);
          }

          string [] alunosams = new string [5];
          alunos[0] = "Guilherme";
          alunos[1] = "Bruno";
          alunos[2] = "Pedro";
          alunos[3] = "Joao";
          alunos[4] = "Lucas";

          Console.WriteLine(alunos[2]);

          alunos[2] = "Pedro";

          Console.WriteLine($"o novo valor do index 2 {alunos[2]}");

          for (int i = 0; i < alunos.Length; i++)
          {
               Console.WriteLine($" Os nomes são : {alunos[i]}");
          }

        }
    }
}