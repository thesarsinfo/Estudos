#include <iostream>
#include <string>
#include "Aviao.h"


using namespace std;
/*
Aula 45 Criando classes em arquivos separados
*/

int main()
{
    Aviao *av1 = new Aviao(3);
    Aviao *av2 = new Aviao(1);
    Aviao *av3 = new Aviao(2);

    av1->Imprimir();
    av2->Imprimir();
    av3->Imprimir();
    return 0;
}