using System;

namespace Aulas
{
    public class Jogador // quando não usamos modificador é automaticamente publica
    {
        public int energia;
        public bool vivo;
        public string nome;
        /*
            Toda classe tem um construtor mesmo que não seja criado aqui no codigo
            faz as declarações fora do contrutor
            e a inicialização no construtor
            a regra é que o construtor tenha o mesmo nome da classe
        */
        public Jogador(string n) // metodo construtor
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        ~Jogador() //Serve de aviso para dizer que a classe foi removida e tirada do garbage collector.
        {
            Console.WriteLine("O objeto Jogador {0} foi destruido", nome);
        }
    }
    class Aula29
    {
        static void Main()
        {   
            string nome1;
            Console.WriteLine("Nome do jogador");
            nome1 = Console.ReadLine();
            //tipo // nome do objeto //  operador new //Nome da Classe          
            Jogador j1 = new Jogador(nome1); //Operador new separa um espaços na memoria
            Jogador j2 = new Jogador("Theo"); //cada objeto funciona indepedende dos outros
            Jogador j3 = new Jogador(nome1);

            j1.energia = 50;

            Console.WriteLine("nome do jogador 1: {0}", j1.nome);
            Console.WriteLine("nome do jogador 2: {0}", j2.nome);
        }
    }
}