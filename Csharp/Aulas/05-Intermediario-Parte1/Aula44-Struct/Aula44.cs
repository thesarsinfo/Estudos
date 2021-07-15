using System;
/*
Struct é tipo especial que armazena tipos de dados diferentes
Struct é tipo Value e seus valores é acesso direto e não pode usa e Classe é tipo Referencia.
Struct não é classe e um pouco mais limitado.
*/
namespace Aula44._05_Intermediario_Parte1
{
    struct Carro
    {   
        public string marca;
        public string modelo;
        public string cor;
        public Carro(string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }
        public void Info()
        {
            Console.WriteLine("Modelo.: {0}", this.modelo);
            Console.WriteLine("cor....: {0}", this.cor);
            Console.WriteLine("Marca..: {0}", this.marca);
        }
    }
    class Aula44
    {
        static void Main()
        {        
            Carro c1 = new Carro("Honda","HRV", "Prata");//Declaração para chamar o construtor
            

            Carro c2; // Declaração padrao
            c2.marca = "VW";
            c2.modelo = "Golf";
            c2.cor = "Azul";

            c1.Info();
            c2.Info();
        }
    }
}