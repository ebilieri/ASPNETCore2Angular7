using GameTOP.Interfaces;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona esta Chutando";
        }

        public string Corre()
        {
            return "Maradona esta Correndo";
        }

        public string Passe()
        {
            return "Maradona esta Passando";
        }
    }
}