using System;

namespace Aula33._02_Iniciante_Parte2
{
    class Jogador
    {
        //Protege o membro sem acesso fora da classe e somente acessados por metodos;
        private int energia;
        private string nome;
        public Jogador(string nome)
        {
            this.nome = nome;
            energia = 100;
        }
        public int getEnergia()
        {
            return energia;
        }
        public string getNome()
        {
            return nome;
        }
        public void setEnergia(int energia)
        {
            if (energia < 0)
            {
                if(this.energia + energia < 0)
                {   
                    this.energia = 0;
                } else
                {
                    
                    this.energia += energia;
                }
            } else if (energia > 0)
            {
                if (this.energia + energia > 100)
                {
                     this.energia = 100;
                } else
                {
                    this.energia += energia;
                }
            }
        }
    }
    class Aula33
    {
        static void Main()
        {        
                /*
                Diferença entre metodo public e private
                */
                Jogador jogador1 = new Jogador("Saraiva");
                jogador1.setEnergia(10);
                Console.WriteLine("Nome: {0}", jogador1.getNome());
                Console.WriteLine("Energia: {0}", jogador1.getEnergia());
                
        }
    }
}