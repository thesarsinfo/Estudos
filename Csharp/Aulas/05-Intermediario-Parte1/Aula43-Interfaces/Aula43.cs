using System;
/*
Interfaces só implementa os metodos ou sua assinaturas e propriedades não usa os campos
Uma classe pode herdar varias interfaces e uma interface não pode ter metodo construtor e destrutor
Não pode ter operator e definir membros statics
    */
namespace Aula43._05_Iniciante_Parte2
{

    public interface IVeiculo 
    {
        //não pode conter variaveis
        void Ligar();
        void Desligar();
        void Info();
    }
    public interface ICombate 
    {
        void Disparar();
    }
    class Carro:IVeiculo,ICombate
    {
        public bool ligado;
        private int municao;
        public Carro()
        {
            SetMunicao(100);
        }
        public void Ligar()
        {
            this.ligado = true;
        }
        public void Desligar()
        {
            this.ligado = false;
        }
        public void Disparar()
        {
            
        }
        public void Info()
        {
            
        }
        public void SetMunicao(int qtde)
        {
            this.municao = qtde;
        }
        
    }


    class Aula43
    {
        static void Main()
        {        
            Carro c1 = new Carro();
        }
    }
}