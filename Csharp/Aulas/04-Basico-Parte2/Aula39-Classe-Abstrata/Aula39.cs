using System;
/*
Classe Base Abstrata serve como referencia para outras classes e não é implementada o comportamento do metodo somente 
o prototipo ou seja metodos prototipo e que herdar é obrigado a implementar
*/
namespace Aula00._02_Iniciante_Parte2
{
    abstract class Veiculo // Classe Base AbstrataEssa classe não pode ser instanciada que vai da erro no compilador.
    {
        protected int velMaxima;
        protected int velAtual;
        protected bool ligado;
        public Veiculo() // contrutor não é abstrato
        {
            ligado = false;
            velAtual = 0;
        }
        public void SetLigado(bool ligado)
        {
            this.ligado = ligado; //Como não foi definido como metodo abstrato e tenho a obrigação de implementar.
        }
         public int GetVelAtual()
        {
            return velAtual; //Como não foi definido como metodo abstrato e tenho a obrigação de implementar.
        }
        abstract public void Aceleracao(int mult);

    }
    class Carro:Veiculo
    {
        public Carro()
        {
            velMaxima = 120;
        }
        override public void Aceleracao(int mult)
        {
            velAtual += 10 * mult;
            
        }
    }
    class Aula39
    {
        static void Main()
        {        
            Carro carro1 = new Carro();
            carro1.Aceleracao(1);
            carro1.Aceleracao(1);
            carro1.Aceleracao(-1);
            Console.WriteLine(carro1.GetVelAtual());
        }
    }
}