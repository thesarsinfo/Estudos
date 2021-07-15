#include <iostream>

using namespace std;

void imprimir(string txt=""); //no prototipo caso seja omitido o valor sera "" por padrao

int main()
{
    /*
        Omissao de argumentos nos parametro de funções
    */
   imprimir("Saraiva");
   //se eu omitir o parametro vai dar erro; E por passamos um valor padrao no prototipos de funçao 
   imprimir();

    return 0;
}

void imprimir(string txt)
{
    cout << "txt:" << txt << endl;
}