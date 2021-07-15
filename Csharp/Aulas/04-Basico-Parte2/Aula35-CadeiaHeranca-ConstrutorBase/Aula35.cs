using System;

namespace Aula35._Basico_Parte02
{
    //Classe Base Veiculo
    class Veiculo
    {
        private int rodas;
        public int velocidadeMaxima;
        private bool ligado;
        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

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
          return (ligado ? "sim" : "não");                
        }
        public int GetRodas()
        {
            return  rodas;
        }  
        public void SetRodas(int rodas)
        {
            if(rodas < 0)
            {
                this.rodas = 0;
            }else if (rodas > 40)
            {
                this.rodas = 40;
            }else
            {
                this.rodas = rodas;
            }
        } 
    }
    class Carro:Veiculo //Classe Derivada
    {
        public string nome;
        public string cor;

        public Carro(string nome , string cor):base(4) // 4 se refere ao argumento int rodas que estamos passado o numero 4
        /*:base se refere a classe base que é Veiculo acima. Essa forma de inicialização é usada quando temos que inicializar
        a classe base usando 1 ou mais argumentos de referencia.
        */
        {
            Desligar();            
            velocidadeMaxima = 120;
            this.nome = nome;
            this.cor = cor;
        }
       
    }
    class CarroCombate:Carro 
    {
        public int municao;
        public CarroCombate():base("Carro de Combate","Verde Oliva")
        {
            municao=100;
            SetRodas(6);
        }
    }
    class Aula35
    {
        static void Main()
        {        
            Carro c1 = new Carro("Rapidão", "Vermelho");
            CarroCombate cc1 = new CarroCombate();
            c1.Ligar();
            Console.WriteLine("Cor.........: {0}",c1.cor);
            Console.WriteLine("Nome........: {0}",c1.nome);
            Console.WriteLine("Rodas.......: {0}",c1.GetRodas());
            Console.WriteLine("Vel.Maxima..: {0}",c1.velocidadeMaxima);
            Console.WriteLine("Carro.ligado: {0}",c1.GetLigado());
             Console.WriteLine("-----------------------------------");
            c1.Ligar();
            Console.WriteLine("Cor.........: {0}",cc1.cor);
            Console.WriteLine("Nome........: {0}",cc1.nome);
            Console.WriteLine("Rodas.......: {0}",cc1.GetRodas());
            Console.WriteLine("Vel.Maxima..: {0}",cc1.velocidadeMaxima);
            Console.WriteLine("Carro.ligado: {0}",cc1.GetLigado());
            Console.WriteLine("Munição:....: {0}",cc1.municao);
            
        }
    }
}