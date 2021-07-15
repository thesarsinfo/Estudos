#include <iostream>
using namespace std;

int main()
{
    //Aula 08 Inversão de valores de variaveis
    int num = 10;
    cout << num << "\n\n";

    //Metodo tradicional

    num = num * -1; //-10
    cout << num << "\n\n";

    //Outra maneira
     cout << -num << "\n\n"; // = 10 usando - na variavel isolada Obs:( Não altera o valor da variavel )
     cout << num << "\n\n"; //valor da ultima modificação
      cout << num << "\n\n"; //confimando o valor

    //ALterando definitivamente o valor
    int num2;
    num2 = 10;
    cout << "O valor de num2: " << num2 << "\n\n";
    cout << "Invertendo e gravando o valor.";
    num2 =- num2;
    cout << "O valor de num2: " << num2 << "\n\n";
    return 0;
}