using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
         public string _Nome { get; set; }

        public Jogador2(string nome){
            _Nome = nome;
        }
        public string Chuta()
        {
            return "Ronaldo está Chutando \n" ;
        }

        public string Corre()
        {
            return "Ronaldo está Correndo \n" ;
        }

        public string Passa()
        {
            return "Ronaldo está Passando \n" ;
        }
    }
}