#include <iostream>
//14/04 aula 3 do dia
using namespace std;

int main()
{
    /*
    Manipular array atraves de ponteiro.
    */

   int *p;
   int vetor[10];
   p = &vetor[0]; // p = vetor ; mesmo codigo .Atribui o endereço do primeiro indice ou
   *p = 10;
   cout << "\n" << vetor[0] << "\n"; // valor int tem 4 byte
   *(p += 1);
   *p = 20;
   cout << "\n" << vetor[1] << "\n";
  *(p+= 1); // o segundo elemento vai ser o proximo endereço da memoria e hexadecima
  *p = 30;
   cout << "\n" << vetor[2] << "\n";

    return 0;
}