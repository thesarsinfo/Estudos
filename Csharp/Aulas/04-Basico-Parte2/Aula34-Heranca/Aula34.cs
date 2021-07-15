using System;

namespace Aula34._Basico_Parte02
{
    //Classe Base Veiculo
    class Veiculo
    {
        public int rodas;
        public int velocidadeMaxima;
        private bool ligado;
        public void Ligar()
        {
            ligado =true;
        }
        public void Desligar()
        {
            ligado =false;
        } 
         public string GetLigado()
        {
          return (ligado) ? "sim" : "não";                
        }   
    }
    class Carro:Veiculo //Classe Derivada
    {
        public string nome;
        public string cor;

        public Carro(string nome , string cor)
        {
            Desligar();
            rodas = 4;
            velocidadeMaxima = 120;
            this.nome = nome;
            this.cor = cor;
        }
       
    }
    class Aula34
    {
        static void Main()
        {        
            Carro c1 = new Carro("Rapidão", "Vermelho");
            c1.Ligar();
            Console.WriteLine("Cor.........:{0}",c1.cor);
            Console.WriteLine("Nome........:{0}",c1.nome);
            Console.WriteLine("Rodas.......:{0}",c1.rodas);
            Console.WriteLine("Vel.Maxima..:{0}",c1.velocidadeMaxima);
            Console.WriteLine("Carro.ligado:{0}",c1.GetLigado());
            
        }
    }
}