//Aula 11 Operadores logicos && e ||
//Tabela verdade;
/*
&& OPERADOR uma condição falsa sempre retornara falso
V   V   = V
V   F   = F
F   V   = F
F   F   = F
|| OR OPERADOR uma condição verdadeira retornara verdadeira
F   F   = F
V   F   = V
F   V   = V
V   V   = V

*/

#include <iostream> //biblioteca para comandos basicos de terminal

using namespace std; //dentro da biblioteca iostream usamos o standart

int main()
{
    // Operadores And or not
    int num = 8;
    if ( num > 4 && num < 7)
    {
        cout << "\n\nValor  And aceito\n";
    } else
    {
        cout << "\n\nValor And nao aceito\n";
    }

    cout << "Condicao Or" << endl;    
     
    if ( num < 3 || num > 8)
    {
        cout << "\n\nValor || or aceito\n";
    } else
    {
        cout << "\n\nValor || or nao aceito\n";
    }
    cout << "Execicio de 3 faixa de valores" << endl;    
    if ((num > 2 && num <7)||(num > 9 && num < 15)||(num > 15 && num < 20) )
    {
        cout << "\n\nvalor aceito\n";
    } else
    {
        cout << "\n\nvalor nao aceito\n";
    }
    cout << "Operador NOT ! \n\n";
    num = 1; // true
    if (!num)
    {
        cout << "\n\nEu vou ao clube\n";
    }else
    {
        cout << "\n\nEu vou no cinema\n";
    }

    system("pause");
    return 0;
}