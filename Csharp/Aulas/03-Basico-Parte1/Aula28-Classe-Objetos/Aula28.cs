using System;

namespace Aulas
{
    public class Jogador // quando não usamos modificador é automaticamente publica
    {
        public int energia = 100;
        public bool vivo = true;
    }
    class Aula28
    {
        static void Main()
        {   
            //tipo // nome do objeto //  operador new //Nome da Classe          
            Jogador j1 = new Jogador(); //Operador new separa um espaços na memoria
            Jogador j2 = new Jogador(); //cada objeto funciona indepedende dos outros
            Jogador j3 = new Jogador();

            j1.energia = 50;

            Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
            Console.WriteLine("Energia do jogador 2: {0}", j2.energia);
        }
    }
}
 /*
            
            [ModificadorClasse ] class Nome_Da_Classe
            {
                Classe possui propriedade = Variaveis 
                [Especificador Acesso] tipo Nome_Propriedade-variavel;

                Metodos = funções
                [Especificador Acesso] retorno Nome_Metodo([args1,...n])
                {
                    //corpo do metodo;
                }
            }
            ModificadorClasse = Define a visibilidade da classe;
                //public: Pública, sem restriçao de visualização
                //abstract: Classe-Base para outras classes, não podem ser instanciadas objeto a essa classe;
                //sealed: Classe não pode ser herdada;
                //static: Classe não permite a instanciaçõa de objetos e seu membros devem ser static
            EspecificadorAcesso: Onde um membro da classe pode ser acesado
                //public: Pública, sem restriçao de visualização
                //private: Só pode ser acessado pela propria classe
                //protected: Podem ser acessado na propria classe e nas classe derivadas
                //abstract Os metodos não tem implementação somente os cabeçalhos
                //seaded: O metodo nao pode ser redefinido usando override;
                // virtual : O metodo pode ser redefinido em uma classe derivada usando override;
                //static: O metodo pode ser chamado mesmo sem a instanciação  de um objeto
        */