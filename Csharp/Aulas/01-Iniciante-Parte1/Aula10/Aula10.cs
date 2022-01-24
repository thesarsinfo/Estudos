using System;

namespace Aula10.Aulas
{
    class Aula10
    {
        enum DiasSemana
        {
            Domingo,
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        };
        static void Main()
        {
            int dss;
           //Aula de enumeradores
           DiasSemana ds = DiasSemana.Domingo;
           Console.WriteLine(ds);
           
           //outra forma de chamar mas lembre se de instanciar pelo menos uma vez;
           ds = (DiasSemana)3;
            Console.WriteLine(ds);
            ds = (DiasSemana)3;
            Console.WriteLine(ds);
            Console.WriteLine(typeof(ds));
            //Pegando o numero do indice
            dss = (int)DiasSemana.Sexta;
            Console.WriteLine(dss);
        }
    }
}