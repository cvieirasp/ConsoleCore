using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new PortuguesePlayer("Carlos");
            var player2 = new EnglishPlayer("Charles");
            var game = new MyGame(player1, player2);
            game.Start();
        }
    }
}
