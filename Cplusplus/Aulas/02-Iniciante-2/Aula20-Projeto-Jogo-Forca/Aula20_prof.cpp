#include <iostream>
#include <stdlib.h>
using namespace std;

int main()
{
    char palavra[30], letra[1],secreta[30];
    int tam, i, chances, acertos;
    bool acerto;

    chances = 6;
    tam = 0;
    i = 0;
    acerto = false;
    acertos = 0;

    cout << "Fale para seu amigo tampar os olhos e digite a palavra secreta: ";
    cin >> palavra;
    system("cls");
    cout << palavra;
    
    while (palavra[i] != '\0')   // \0 é um regex de enter 
    {
        i++;
        tam++;
    }
    for (i = 0; i < 30; i++)
    {
        secreta[i] = '_';
    }
    while ((chances > 0) && (acertos < tam))
    {
        cout << "Chances restantes: " << chances << endl;
        cout << "Palavra secrete: ";
        for (i = 0; i < tam; i++)
        {
            cout << secreta[i];
        }
        cout << endl << endl << "digite uma letra: " << endl;
        cin >> letra[0];
        for ( i = 0; i < tam; i++)
        {
            if(palavra[i] == letra[0])
            {
                acerto=true;
                secreta[i] = palavra[i];
                acertos++;
            }
        }
        if (!acerto)
        {
            chances--;
        }
        acerto=false;
        system("cls");
    }
    if (acertos == tam)
    {
        cout << "Voce Ganhou!!" << endl;
    } else
    {
        cout << "Voce perdeu que pena!!" << endl;
    }
    system("pause");
    return 0;
}