using System;
/*
Classe Sealed é uma classe que não pode ser Herdada.
*/
namespace Aula40._04_Basico_Parte2
{
    sealed class Veiculo // Não pode ser Herdada e pode ser instanciada!!
    {

    }
    class Carro:Veiculo
    {

    }
    class Aula40    
    {
        static void Main()
        {        
            Carro c1 = new Carro();
        }
    }
}