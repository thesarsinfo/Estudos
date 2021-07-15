using System;

namespace Aula36._02_Iniciante_Parte2
{
    class Veiculo
    {
        public int velocidadeAtual;
        private int velocidadeMaxima; // private somente a classe pode acessar e classe derivada não tem acesso. Somente
        // usando metodos public.
        protected bool ligado; //O acesso é da sua classe base e a classe derivada
        public Veiculo(int velocidadeMaxima)
        {
            velocidadeAtual = 0;
            this.velocidadeMaxima = velocidadeMaxima;
            ligado = false;
        }
        public bool GetLigado()
        {
            return ligado;
        }
        public int GetVelocidadeMaxima()
        {
            return velocidadeMaxima;
        }
    }
    class Carro:Veiculo // Derivada de veiculo
    {
        public string nome;
        public Carro(string nome, int vm):base(vm)
        {
            this.nome = nome;
            ligado = true;
        }
    }
    class Aula36
    {
        static void Main()
        {        
               /*
               Protected é semelhante ao private mas tem suas utilizades.
               */        
               Carro carro = new Carro("Bonitao", 120);
               Console.WriteLine("Nome.............: {0}",carro.nome);
               Console.WriteLine("Velocidade Maxima: {0}",carro.GetVelocidadeMaxima());
               Console.WriteLine("Carro Ligado.....: {0}",carro.GetLigado());
        }
    }
}