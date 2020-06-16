using System;

namespace jogador
{
    class Program
    {
        static void Main(string[] args)            
        {
           
            Jogador ribamar = new Jogador();
            ribamar.Nome= "ribamar";
            ribamar.Altura = 1.80f;
            ribamar.Peso = 80f;
            ribamar.Nascimento = DateTime.Parse("24/06/1887");
            ribamar.Posicao = "Goleiro";
            Console.WriteLine(ribamar.CalcularIdade());
            Console.WriteLine(ribamar.VerificarAposentadoria());
            
        }
    }
}
