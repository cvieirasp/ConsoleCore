using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class PortuguesePlayer : IPlayer
    {
        public readonly string Nome;

        public PortuguesePlayer(string nome)
        {
            this.Nome = nome;
        }

        public string Kick()
        {
            return $"{Nome} está chutando a bola.";
        }

        public string Run()
        {
            return $"{Nome} está correndo em direção ao gol.";
        }

        public string Pass()
        {
            return $"{Nome} está tocando a bola para seu companheiro.";
        }
    }
}