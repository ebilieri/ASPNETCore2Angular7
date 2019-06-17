using GameTOP.Interfaces;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _nome;

        public Jogador1(string nome)
        {
            _nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return ($"{_nome} está Chutando");
        }

        //corre
        public string Corre()
        {
            return ($"{_nome} está Correndo");
        }
        //passe
        public string Passe()
        {
            return ($"{_nome} está Passando");
        }
    }
}