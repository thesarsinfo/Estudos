using System;

namespace Aulas
{
    public class Jogador // quando não usamos modificador é automaticamente publica
    {
        public int energia;
        public bool vivo;
        public string nome;
        /* 
        SObrecarga de contrutor é nada mais do que o metodo do contrutor varias implementações diferentes
        ou seja varios metodos jogador só que com passagem de parametros diferentes.
        Serve para metodos comuns.
        */
        public Jogador()
        {
            energia = 100;
            vivo = true;
            nome = "Jogador";
        }
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e)
        {
            energia = e;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e, bool v)
        {
            energia = e;
            vivo = v;
            nome = n;
        }
        public void info()
        {
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador: {0}",energia);
            Console.WriteLine("Estado do jogador: {0}\n",vivo);
        }       
        
    }
    class Aula30
    {
        static void Main()
        {   
            
            //tipo // nome do objeto //  operador new //Nome da Classe          
            Jogador j1 = new Jogador(); //Operador new separa um espaços na memoria
            Jogador j2 = new Jogador("Thiago"); //cada objeto funciona indepedende dos outros
            Jogador j3 = new Jogador("Théo",100);
            Jogador j4 = new Jogador("Venegundes", 30 ,true);
            Jogador j5 = new Jogador("juno",0,false);

            j1.info();
            j2.info();
            j3.info();
            j4.info();
            j5.info();

           
        }
    }
}