#include <iostream> //biblioteca para comandos basicos de terminal
#include <cstdlib> // Alguns comandos do dos são carregados

using namespace std; //dentro da biblioteca iostream usamos o standart

int main()
{
    //Aula 10-- If else e comando Goto
    int n1, n2 ,res;
    char opc;

    inicio:  //Comando Goto
    system("cls"); //Necessita o uso da biblioteca cstdlib

    cout << "Digite o valor da nota 1: " << endl;
    cin >> n1;
    cout << "Digite o valor da nota 2: " << endl;
    cin >> n2;
    res = n1 + n2;
    if (res >= 60)
    {
        cout << "\nAluno Aprovado\n";
    } else
    {
        cout << "\nAluno reprovado\n\n";
    }
    cout << "Mudei de regra!!!!" << endl;
    // >= 60 Aprovado >= 40 e <=40 recuperação < 40 reprovado.
    if (res >= 60)
    {
         cout << "\nAluno Aprovado\n";
    } else if ( res >= 40)
    {
         cout << "\nAluno em recuperacao\n";
    } else
    {
         cout << "\nAluno Aprovado\n";
    }

    cout << "\nDigitar outras notas?[s/n]: ";
    cin >> opc;

    if (opc == 's' or opc=='S')
    {
        goto inicio;
    }
    return 0;
}