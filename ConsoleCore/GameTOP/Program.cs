using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {            
            var jogo = new JogoFoga(
                new Jogador1("Ronaldo"),
                new Jogador3()
                );
                
            jogo.IniciarJogo();
        }
    }

   
}
