using GameTOP.Interfaces;

namespace GameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Chuta";
        }

        public string Corre()
        {
            return "Corre";
        }

        public string Passe()
        {
            return "Passa";
        }
    }
}