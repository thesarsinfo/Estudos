using System;

namespace Aula31.Aulas 
/* Theoria 
Aula 31 - A classe static não podemos usar contrutores e nem instanciar o objeto
porque ja deixa fixo o objeto na memoria e por isso não podemos instanciar.
Toda classe static deve ter membros e propriedades static
e uma classe não static pode ter membro static.

*/
{   
    public class Inimigo
    {
        static public bool alerta;
        public string nome;
        public Inimigo(string n)
        {
            alerta = false;
            nome = n;
        }
        public void Info()
        {
            Console.WriteLine(nome);
            Console.WriteLine(alerta);
            Console.WriteLine("------------------------------");
        }

    }
    static public class Jogador // quando não usamos modificador é automaticamente publica
    {
        static public int energia;
        static public bool vivo;
        static public string nome;
        /* 
        SObrecarga de contrutor é nada mais do que o metodo do contrutor varias implementações diferentes
        ou seja varios metodos jogador só que com passagem de parametros diferentes.
        Serve para metodos comuns.
        */
        static public void Iniciar(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        
        static public void Info()
        {
            Jogador.energia = 90;
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador: {0}",energia);
            Console.WriteLine("Estado do jogador: {0}\n",vivo);
        }               
    }
    class Aula30
    {
        static void Main()
        {               
            Jogador.Iniciar("Thiago");
           Jogador.Info();

           Inimigo i1 = new Inimigo("Doido");
           Inimigo i2 = new Inimigo("Maluco");
           Inimigo i3 = new Inimigo("Pirado");
            // Cocando o Alerta com static public isso possibilita a alteração
            // da propriedade de todas as instancias ao mesmo tempoa
            Inimigo.alerta = true;

           i1.Info();
           i2.Info();
           i3.Info();
        }
    }
}