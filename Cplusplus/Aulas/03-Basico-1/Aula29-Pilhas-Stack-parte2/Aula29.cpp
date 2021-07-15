#include <iostream>
#include <stack>
#include <string>

using namespace std;

int main()
{
    // Aula 29 Verificando metodos para ver se a pilha está vazia ou delete.
    stack <string> cartas;

    if ( cartas.empty())
    {
        cout << "Pilha vazia" << endl << endl;
    } else
    {
        cout << "Pilha com cartas" << endl << endl;
    }

    cartas.push("Rei de Copas");
    cartas.push("Rei de Espadas");
    cartas.push("Rei de Ouros");
    cartas.push("Rei de Paus");

    cout << "tamanho da pilha: " << cartas.size() << "\n";
    while (!cartas.empty())
    {
         cartas.pop();
        cout << "tamanho da pilha: " << cartas.size() << "\n";
        if (cartas.size() > 0)
        {
            cout << "Carta do topo: " << cartas.top() << "\n";
        } else
        {   
            cout << "Pilha vazia" << endl;
        }
    }

    return 0;
}