using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args){
            var jogo = new JogoFODA(new Jogador1("Ramon"), new Jogador2("Juan"));
            jogo.IniciarJogo();
        }
    }
}
