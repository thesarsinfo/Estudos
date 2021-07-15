// Escopo global e local  e operadores matematicos

#include <iostream>

using namespace std;

int numberThree, numberFour; // variaveis globais

int main()
{
    //variavel local
    int numberOne, numberTwo, result, resultMod;

    //Operadores matematicos + - * / % ()

    numberOne = 11;
    numberTwo = 3;
    numberThree = 5;
    numberFour = 2;

    result = numberOne + numberTwo + numberThree + numberFour;
    cout << "Soma de todas as variaveis: " << result << "\n\n";
    result = numberOne + numberTwo * numberFour;
    cout << "Resultado: " << result;
    result = numberOne / numberTwo;
    resultMod = numberOne % numberTwo;
    cout << "Divisão: " << result;
    cout << "Resto: " << resultMod;


    return 0;
}