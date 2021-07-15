//Aula de incremento e decremento de variaveis, Operadores pós e pré fixados.
#include <iostream>

using namespace std;

int main()
{
    int n1, n2;
    n1 = 0;
    n2 = 10;
    //formas de incremento ou decremento
    cout << n1 << "\n\n";
    n1= n1 + 1; //forma não tradicional
    
    cout << n1 << "\n\n";

    n1 += n2; // Forma atual e lebramdo que podemos fazer isso na 4 operadores
    cout << n1 << "\n\n";
    n1 -= 2;
    cout << n1 << "\n\n";
    n1 *= 3;
    cout << n1 << "\n\n";
    n1 /= 2;
    cout << n1 << "\n\n";
    n1 %= n2;   

    cout << n1 << "\n\n";

    n1++; // muito mais usado como contador.

    cout << n1 << "\n\n";

    //Utilizando o pre incremento
    int n3;
    n3 = 10;
    n3++;
    cout << "O valor de n3: "<< n3 << "\n\n";
    ++n3;
    cout << "O valor de n3: "<< n3 << "\n\n";
    //Voce pode ver que o valores são iguais
    //A diferença pode está na impressao
    n3 = 10;
    cout << "O valor de n3 pos: "<< n3++ << "\n\n";//usa o valor e depois incrementa
    n3 = 10;
    cout << "O valor de n3 pre: "<< ++n3 << "\n\n";//incrementa e depois usa o valor


    return 0;
}