using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class EnglishPlayer : IPlayer
    {
        public readonly string Nome;

        public EnglishPlayer(string nome)
        {
            this.Nome = nome;
        }

        public string Kick()
        {
            return $"{Nome} is kicking the ball.";
        }

        public string Run()
        {
            return $"{Nome} is running towards the goal.";
        }

        public string Pass()
        {
            return $"{Nome} is passing the ball to his mate.";
        }
    }
}