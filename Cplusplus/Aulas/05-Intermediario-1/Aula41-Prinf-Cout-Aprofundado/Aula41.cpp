#include <iostream>
#include <stdio.h> // para o printf
#include <math.h> // C para matematica
#include <iomanip> // manipulação de entrada e saida.

using namespace std;

int main()
{
    /*
    Aula 41 formatações com cout e uso do printf
    */
   int num = 5;
   float pi = M_PI;
   printf("Valor de pi: %07.2f", pi); // isso em C do printf
   printf("Valor de num: %d07", num); // isso em C colocando numeros 0 a esquerda
   //possibilidades de cout
   int num1 = 15;
   cout << endl << endl << "Valor de num1 em decimal: " << num1 << endl;
   cout << endl << "Valor de num1 em hexadecimal: " << hex << num1 << endl; // usa hex antes
   cout << endl << "Valor de num1 em octadecimal: " << oct << num1 << endl; // usa oct antes
   cout << endl << "Valor de num1 em decimal caso pegue o numero em hexa ou octase: " << dec << num1 << endl; // usa oct antes
    // Usando prescisao de numero
    cout.precision(3); // imprime 2 casas porque no 3 conta 1
    cout << pi << endl;
    cout.precision(31);
    cout << pi << endl;
    // para voltar ao padrao
    cout.precision(-1);
    // imprimindo em notação cientifica
    cout << "Valor de Pi: " << scientific << pi << endl;

    int num2 = 30;
    cout << endl << "Valor de num2:" << setw(10) << num2 << endl; // setw = setwidth serve para tabulação em app console
    cout << endl << "Valor de num2:" << setw(10) << setfill('.') <<num2 << endl; // setfill = preenche com char os valores do setw
    
    
    return 0;
}
