using GameTOP.Interface;

namespace GameTOP
{
    public class MyGame
    {
        private readonly IPlayer PlayerBR;
        private readonly IPlayer PlayerEN;

        public MyGame(IPlayer playerBR, IPlayer playerEN)
        {
            PlayerBR = playerBR;
            PlayerEN = playerEN;
        }
        public void Start() 
        {
            System.Console.WriteLine(PlayerBR.Pass());
            System.Console.WriteLine(PlayerBR.Run());
            System.Console.WriteLine(PlayerBR.Kick());

            System.Console.WriteLine("\nPRÓXIMO JOGADOR\n");

            System.Console.WriteLine(PlayerEN.Pass());
            System.Console.WriteLine(PlayerEN.Run());
            System.Console.WriteLine(PlayerEN.Kick());
        }
    }
}